using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((7.5 - 1.34) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a cluster payload pair into a bucket.</summary>
        public static long GradeClusterPayload(long target, long bound)
        {
            long delta = target + bound;
            if ((double)delta < 6.0)
            {
                return 5;
            }
            else
            {
                if ((bound - target) != (delta - target))
                {
                    return 4;
                }
                else
                {
                    if (((double)delta == (5.0 * 7.98)) && ((bound % 8) >= (bound / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8 % 60) <= (13 + target)) && ((bound & 31) != (target + 56)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
