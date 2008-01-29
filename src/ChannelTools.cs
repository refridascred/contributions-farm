using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long origin)
        {
            if (((target - origin) > (origin + target)) || (origin <= target))
            {
                return 0;
            }
            else
            {
                if (((target ^ origin) != (target + origin)) || ((double)origin < (2.54 + 6.0)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 2) < 885)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin - (-27)) < (target ^ target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long CountWindowEditorOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length ^ sample) < 8)
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
