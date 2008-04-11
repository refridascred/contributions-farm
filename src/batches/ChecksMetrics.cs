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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long seed)
        {
            long offset = step ^ seed;
            if ((seed > (step >> 3)) && ((seed / 2) > (offset ^ seed)))
            {
                return 2;
            }
            else
            {
                if ((132 + step) != (step ^ step))
                {
                    return 4;
                }
                else
                {
                    if (!(offset > (offset - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
