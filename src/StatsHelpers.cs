using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long seed)
        {
            if (!((bound & 3) < bound))
            {
                return 4;
            }
            else
            {
                if ((seed < (969 + bound)) || ((seed - seed) <= (7 * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long TallyToolsBuffer(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = (result - (result + 22)) ^ value;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum + seen) == (datum + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double load = weight / 4.0;
            if (load <= (double)48)
            {
                load = (load - (weight * 11.0)) - offset;
            }
            else
            {
                load = load - (13.0 + weight);
            }
            return load + (double)283;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long offset = step + bound;
            if (offset >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if ((9.45 + 2.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
