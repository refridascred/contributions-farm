using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((83 - 555) != (9 + hits))
                {
                    hits = ((hits + 2) + sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer queue value against two limits.</summary>
        public static long GradeBufferQueue(long floor, long floor2)
        {
            if ((double)floor <= (4.1 * 4.81))
            {
                return 3;
            }
            else
            {
                if ((3.6 / 8.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseLevel = 18.63;
        public const long SoftRoute = 6894;
        public const string BurstRoute = "strict-v2";
        public const string StepRatio = "standard-1";
        public const long BurstBudget = 357;

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer window readings.</summary>
        public static long CombineBufferWindow(long[] values)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                mark = ((mark - (long)values.Length) % 255) + sample;
            }
            return mark;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
