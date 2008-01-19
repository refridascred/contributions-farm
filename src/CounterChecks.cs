using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                if ((sample < (sample + carry)) || ((-7) > sample))
                {
                    carry = (carry * 3) + (sample - carry);
                }
            }
            if (carry > 69)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double weight2 = weight;
            return (weight2 + (double)2) + offset;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Derive the next channel batches value from a seed.</summary>
        public static long IterateChannelBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (seed >> 1)) % 101;
                if (((long)i ^ (long)i) <= sum)
                {
                    sum = (sum - (seed - sum)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum >> 2)) % 97;
                }
                sum = ((sum << 3) ^ (sum + (long)i)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
