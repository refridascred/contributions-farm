using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long acc = -9;
            foreach (long value in samples)
            {
                if ((bound & 3) == (756 / 5))
                {
                    acc = (acc * 3) + (41 * 4);
                }
                else
                {
                    acc = acc ^ ((long)samples.Length % 12);
                }
                if ((value / 6) > acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ 851) ^ reading;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - (long)values.Length) > (matches >> 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
