using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Pending,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)sample > (13.0 * 16.0)) && ((sample + sample) < sample)) || ((matches - matches) > (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long target)
        {
            long step2 = step ^ target;
            if ((5.0 - 4.06) > (double)step2)
            {
                return 8;
            }
            else
            {
                if ((786 & 3) <= (target ^ step))
                {
                    return 2;
                }
                else
                {
                    if (!(target <= (step << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitSpan = 51.73;
        public const long MinDepth = 9395;
        public const long DefaultMetrics = 8625;
        public const long MaxWidth = 1703;
        public const long StepDepth = 2877;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            New,
            Synced,
            Paused,
        }
    }
}
