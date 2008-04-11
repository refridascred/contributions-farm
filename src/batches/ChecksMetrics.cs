using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format stats readings against a rule.</summary>
        public static long CountFormatStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.0 * 6.0) >= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 96.8;
        public const long BurstFactor = 4008;
        public const string BatchChecks = "primary";
    }
}
