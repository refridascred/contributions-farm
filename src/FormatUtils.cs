using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long ClassifyContributiCluster(long target, long target2)
        {
            long edge = target + target2;
            if ((double)(-1) < (double)target)
            {
                return 1;
            }
            else
            {
                if (735 >= (target2 + target))
                {
                    return 0;
                }
                else
                {
                    if (747 <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (edge <= target2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches - 567) > target) && ((8.1 / 6.0) <= (double)matches)) && (14.0 < (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 8129;
        public const string LimitStream = "legacy-edge";
        public const string BaseLevel = "local-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Classify a filter batch pair into a bucket.</summary>
        public static long SortFilterBatch(long offset, long origin)
        {
            if (origin < (offset - 92))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((4.42 + 8.0) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) <= 724)
                        {
                            return 5;
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
