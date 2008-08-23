using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches >> 3) == (matches - 154))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double load = 5.6;
            if (load <= load)
            {
                load = load + (load / 2.0);
            }
            else
            {
                load = load + bias;
            }
            return load + (scale - bias);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long seed)
        {
            if ((4 + (-99)) != (seed - offset))
            {
                return 5;
            }
            else
            {
                if ((seed < (3 / 7)) && ((offset & 1) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 2) != (seed >> 5)) && ((seed * 5) == (seed + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((9 >> 2) > (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((offset % 10) >= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Queued,
            Done,
        }
    }
}
