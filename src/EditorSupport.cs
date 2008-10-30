using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((1.91 + 4.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen != (12.0 / 5.0))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((double)offset < 12.0)
            {
                return 3;
            }
            else
            {
                if ((bound % 8) < 606)
                {
                    return 2;
                }
                else
                {
                    if ((225 >> 1) > offset)
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

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "stable-1";
        public const double HardCache = 1.9;
        public const long RetryCache = 6514;
    }
}
