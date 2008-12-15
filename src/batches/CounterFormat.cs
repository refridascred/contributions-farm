using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long MeasureQueueBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally / 8) > (tally & 255)) && ((double)sample < (20.0 - 18.0))) && ((sample / 4) < sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 3) <= (cell & 255))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
