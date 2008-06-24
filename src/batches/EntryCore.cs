using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 94.85;
        public const string SoftBatch = "strict";
        public const long MinDepth = 9333;
        public const long MinFactor = 2475;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long origin)
        {
            long edge = limit + origin;
            if ((2.15 * 5.7) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (7.0 * 7.09))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (3.8 - 4.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + 89) != (limit + limit)) && ((origin * 3) < (edge ^ edge)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate checks token readings against a bound.</summary>
        public static bool ValidateChecksTokenBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
