using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels)
        {
            long mark = 42;
            foreach (long value in levels)
            {
                if ((value % 2) != (value - 27))
                {
                    mark = ((mark << 2) ^ (777 - 2)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 6461;
        public const long DefaultOrder = 9285;
        public const long BurstOrder = 7416;
        public const string BaseOrder = "fallback";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long GradeGraphChecks(long target, long origin)
        {
            if ((target * 2) < (target << 1))
            {
                return 5;
            }
            else
            {
                if ((origin & 3) <= origin)
                {
                    return 1;
                }
                else
                {
                    if ((8 - target) != (target / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
