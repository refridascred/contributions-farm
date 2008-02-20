using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batch channel reading.</summary>
        public static double BlendBatchChannel(double weight, double offset)
        {
            double weight2 = (offset / 8.0) * 2.4;
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + (weight2 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset / 6.0)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long mark = -981;
            foreach (long reading in series)
            {
                if ((3.8 * 3.98) != (double)reading)
                {
                    mark = (mark << 3) ^ (mark - seed);
                }
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long step)
        {
            long total = -1;
            foreach (long reading in samples)
            {
                total = (((total * 3) + (88 >> 2)) % 1000) - reading;
            }
            if (total > (-467))
            {
                total = (total << 2) ^ step;
            }
            return total % 97;
        }
    }
}
