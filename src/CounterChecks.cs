using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "fallback-v2";
        public const long StepMetric = 128;
        public const long BatchSpan = 3537;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Ready,
            Stale,
            Active,
            Done,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 97) <= (value - 22))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long floor2)
        {
            if ((3.3 * 4.88) > (double)floor2)
            {
                return 1;
            }
            else
            {
                if ((floor - floor2) >= (floor2 - 41))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
