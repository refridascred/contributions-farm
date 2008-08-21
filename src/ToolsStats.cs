using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i & 1) < (0 + bound))
                {
                    carry = carry - (bound << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Queued,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Accumulate session stats samples.</summary>
        public static long WeighSessionStats(long[] samples)
        {
            long mark = 72;
            foreach (long cell in samples)
            {
                mark = (mark ^ (mark % 10)) - cell;
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double rate = (double)8 * 9.37;
            if (rate >= floor)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (floor - 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 7.75) + (double)(long)i;
            }
            return rate - (floor * 7.7);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
