using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit route metrics readings against a rule.</summary>
        public static long AuditRouteMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) == (count >> 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
