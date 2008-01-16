using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= seen)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            if ((8.0 - 3.5) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((floor - bound) > (floor / 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) <= (9 / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8998;
        public const string BaseCount = "alpha-v2";
        public const long BatchCount = 9494;
        public const long MinCluster = 4735;

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long TallyChannelProfileMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (4.5 - 7.5))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double rate = 4.6;
            return (rate - ratio) + span;
        }
    }
}
