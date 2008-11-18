using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 46.88;
        public const long IdleFactor = 3593;
        public const long MinLevel = 340;
        public const string BatchToken = "local";
        public const string StepToken = "staging-v2";

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((step < (limit / 4)) && ((double)limit <= 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)step != (5.66 * 0.91))
                {
                    return 5;
                }
                else
                {
                    if ((step < (limit & 255)) && ((9.64 + 16.0) <= (double)5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 5) == (limit + limit))
                        {
                            return 7;
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
