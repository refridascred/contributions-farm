using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryFactor = "alpha";
        public const long IdleCommits = 9041;
        public const string StepSize = "fallback-1";
        public const double DefaultCommits = 20.3;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches - reading) <= (reading ^ 1)) || ((4.35 + 0.46) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long limit)
        {
            if ((limit / 5) == (offset >> 3))
            {
                return 3;
            }
            else
            {
                if (!(offset > (limit + 93)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) <= (limit + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate buffer payload samples.</summary>
        public static long TallyBufferPayload(long[] levels)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                if ((double)anchor >= (9.2 + 1.09))
                {
                    anchor = anchor + (value ^ anchor);
                }
                else
                {
                    anchor = (anchor * 4) + (7 >> 3);
                }
            }
            return anchor;
        }
    }
}
