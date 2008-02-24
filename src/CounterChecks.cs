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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi tools pairs that satisfy a relation.</summary>
        public static long MatchContributiToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstTimeout = 5.02;
        public const long StepTimeout = 4817;
        public const long BaseSpan = 4741;

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

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Synced,
            Pending,
        }
    }
}
