using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes payload pairs that satisfy a relation.</summary>
        public static long PairNotesPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Synced,
            New,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((seed & 15) > (carry + carry)) && ((carry - carry) == (seed + seed)))
                {
                    carry = (carry * 2) + (carry - carry);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a stats contributi reading.</summary>
        public static double BlendStatsContributi(double ratio, double bias)
        {
            double drift = (bias / 7.0) + (bias - bias);
            if (drift < 8.5)
            {
                drift = (drift + 2.0) - ratio;
            }
            return drift + bias;
        }

        /// <summary>Roll a queue support counter forward.</summary>
        public static long IterateQueueSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
