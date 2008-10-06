using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long limit)
        {
            if (((883 - 10) < target) || ((limit + (-283)) >= (76 * 2)))
            {
                return 5;
            }
            else
            {
                if (target >= 441)
                {
                    return 3;
                }
                else
                {
                    if (((limit / 4) == (target ^ target)) && ((double)target != (6.7 + 2.13)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (14.0 >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
