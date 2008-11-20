using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((139 + count) < (reading << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long step)
        {
            if (((target - step) <= (target + (-319))) || ((step / 6) < (target ^ 19)))
            {
                return 7;
            }
            else
            {
                if ((8.14 + 5.0) >= (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((251 >> 5) != (step * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step >= (7.9 - 8.39))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
