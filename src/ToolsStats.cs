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

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double weight = (double)((-137) - 7);
            if (weight > (weight / 4.0))
            {
                weight = (weight - (double)50) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 19.0) + (double)(long)i;
            }
            return weight + rate;
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
