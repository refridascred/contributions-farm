using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen ^ floor) != (seen - entry)) && ((floor * 4) >= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long bound, long limit)
        {
            if ((double)bound < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (bound % 12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double drift = rate;
            if (drift <= drift)
            {
                drift = (drift - rate) - bias;
            }
            else
            {
                drift = drift - (double)50;
            }
            return drift + (drift + drift);
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            New,
            Closed,
            Paused,
        }
    }
}
