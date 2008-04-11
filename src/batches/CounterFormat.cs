using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (7.92 - 8.6))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
