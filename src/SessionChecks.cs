using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long lane = offset - origin;
            if (3.5 > (double)offset)
            {
                return 6;
            }
            else
            {
                if (!((origin >> 5) >= (offset >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (lane >= (262 / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Stale,
            New,
            Pending,
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double span)
        {
            double drift = (double)(8 / 9);
            if (drift <= 5.0)
            {
                drift = ((drift + (4.08 / 5.0)) - bias) - span;
            }
            else
            {
                drift = drift - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)(-74)) - (double)(long)i;
            }
            return drift - (double)24;
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long StepLayoutBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)floor < (18.0 - 8.11)))
                {
                    total = (total << 3) ^ ((long)i / 8);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
