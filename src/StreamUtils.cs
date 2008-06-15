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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + matches) == (110 + matches))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

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
