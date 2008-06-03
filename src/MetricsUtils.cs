using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (double)(9 << 1);
            if (weight < (bias / 9.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)709;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = 99;
            foreach (long sample in samples)
            {
                if ((7 & 255) == (carry / 2))
                {
                    long span = (carry << 2) * 2;
                    carry = ((carry << 2) ^ (1 + span)) % 97;
                }
                else
                {
                    long step = carry + (carry + 773);
                    carry = ((carry << 3) ^ (step - sample)) % 65521;
                }
                carry = (carry << 2) ^ (carry >> 3);
                if ((double)sample >= 8.97)
                {
                    carry = (carry + (carry & 63)) % 4096;
                }
            }
            if (carry > 83)
            {
                carry = (carry * 3) + (-3);
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long limit)
        {
            long result = -942;
            foreach (long reading in items)
            {
                if (((result / 5) >= (reading % 2)) || (0 <= result))
                {
                    result = (result - reading) % 101;
                }
            }
            if (result < 62)
            {
                result = ((result * 2) + (limit - limit)) % 101;
            }
            return result;
        }
    }
}
