using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long target)
        {
            long span = origin ^ target;
            if ((double)target > (3.1 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)span == (double)target)
                {
                    return 2;
                }
                else
                {
                    if (span >= 31)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin > 8.23) || ((target - (-487)) > (span ^ span)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 71.46;
        public const string LimitDepth = "strict-edge";
        public const string DefaultEntry = "latest-1";
    }
}
