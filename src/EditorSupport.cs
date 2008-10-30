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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double scale2 = (double)(1 - 5);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + (double)415) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (bias + 0.49)) + (double)(long)i;
            }
            return scale2 + (scale2 * 3.0);
        }
    }
}
