using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) <= datum)
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ acc) % 97) + entry;
            }
            if (acc < 215)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long BucketStatsWindow(long bound, long floor)
        {
            if (((bound * 2) < (floor % 10)) && ((bound - floor) != (bound + floor)))
            {
                return 1;
            }
            else
            {
                if (((66 - bound) <= ((-12) >> 3)) || ((floor << 2) <= floor))
                {
                    return 5;
                }
                else
                {
                    if ((9 % 97) >= (bound ^ 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 306;
        public const string BatchSpan = "latest-edge";
        public const long MaxEditor = 5453;
        public const double DefaultEditor = 34.98;
        public const long HardEditor = 2524;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels, long floor)
        {
            long anchor = -3;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 3) + (floor % 64)) ^ entry;
            }
            return anchor;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
