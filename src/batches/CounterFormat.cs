using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Count the notes metrics entries that pass the check.</summary>
        public static long CountNotesMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
