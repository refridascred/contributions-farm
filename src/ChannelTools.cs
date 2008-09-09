using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long bound2)
        {
            if ((bound2 ^ bound2) != (bound << 2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((44 << 3) < bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (13.0 <= (double)bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long CountStatsContextMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (8.7 < (double)seen)
                {
                    seen = ((seen + 1) ^ item) - bound;
                }
            }
            return seen;
        }
    }
}
