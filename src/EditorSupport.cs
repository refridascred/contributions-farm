using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)359 != (double)datum)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Count command already pairs that satisfy a relation.</summary>
        public static long PairCommandAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long TallyRecordGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (1.2 >= (double)(long)items.Length)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Draft,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 45.13;
        public const long SoftLevel = 5364;
        public const long BatchWindow = 1155;
        public const long MaxWindow = 8562;
        public const long RetryWindow = 8905;
    }
}
