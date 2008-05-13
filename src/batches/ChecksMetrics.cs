using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long TallyToolsMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading < 9.37) && ((seen + seen) == (reading ^ reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate tools notes readings against a bound.</summary>
        public static bool ValidateToolsNotesLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            long lane = bound - offset;
            if ((offset >> 4) != (bound / 9))
            {
                return 2;
            }
            else
            {
                if ((bound % 5) == (bound >> 2))
                {
                    return 1;
                }
                else
                {
                    if (lane > (lane >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 4397;
        public const long RetryDepth = 2887;
        public const long DefaultSpan = 1344;
        public const long IdleFactor = 9713;
    }
}
