using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long span = floor - bound;
            if (span <= (span * 2))
            {
                return 3;
            }
            else
            {
                if (685 <= span)
                {
                    return 2;
                }
                else
                {
                    if (((floor << 2) <= bound) || ((double)floor >= (3.87 - 14.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((686 / 5) != (bound << 1))
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

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
