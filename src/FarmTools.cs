using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long target)
        {
            long gap = floor + target;
            if (0.23 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((target + gap) > (target + 8))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.16 * 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap << 3) <= (target / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value / 3) >= (offset - 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
