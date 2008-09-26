using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (item / 2))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches + 279) <= (value + value)) && ((matches % 64) >= (value << 2)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] series, long target)
        {
            long state = -726;
            foreach (long item in series)
            {
                state = (((state ^ (state - state)) % 65521) ^ item) + target;
            }
            return state % 4096;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Queued,
            New,
        }
    }
}
