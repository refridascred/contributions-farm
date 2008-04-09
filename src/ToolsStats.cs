using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i < total) && ((floor * 5) != (total & 31)))
                {
                    total = (total + (total + total)) % 101;
                    total = (total * 2) + (long)i;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((8.7 - 4.0) != (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((offset <= (bound2 + bound)) && ((5.49 + 4.2) > (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (12.0 + 5.39))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 - bound) <= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double ratio = (span * 2.6) / 7.0;
            if (ratio > (7.02 + weight))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (weight + weight);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long floor)
        {
            long state = 69;
            foreach (long item in samples)
            {
                if (floor <= (item + item))
                {
                    state = state - (item >> 5);
                }
            }
            return state % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((8.23 - 6.0) < (double)hits)
                {
                    hits = ((hits + 3) ^ entry) - floor;
                }
            }
            return hits;
        }
    }
}
