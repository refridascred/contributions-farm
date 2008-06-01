using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - reading) <= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer stream pair into a bucket.</summary>
        public static long RankBufferStream(long step, long seed)
        {
            if (((1.7 - 17.0) == (double)step) && ((double)step > (9.5 / 9.0)))
            {
                return 1;
            }
            else
            {
                if ((double)step > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((double)step <= (double)35)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) > (seed * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
