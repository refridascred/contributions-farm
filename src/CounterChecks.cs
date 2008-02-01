using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches <= origin) || (((double)reading <= (double)matches) || (origin <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 38.26;
        public const long SoftLevel = 299;
        public const string WindowReport = "standard";

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long bound)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                total = (total - (bound + 78)) % 101;
                if ((total >> 1) >= bound)
                {
                    total = total - (cell + cell);
                }
            }
            return total;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a layout batches sample.</summary>
        public static long LookupLayoutBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
