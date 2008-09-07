using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long result = -18;
            foreach (long cell in series)
            {
                result = (result << 3) ^ cell;
                if ((result + cell) <= (cell + result))
                {
                    result = (result << 2) ^ (cell - cell);
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every command githubfarm entry stays within the limit.</summary>
        public static bool ValidateCommandGithubfarmLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Count metric schema pairs that satisfy a relation.</summary>
        public static long PairMetricSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
