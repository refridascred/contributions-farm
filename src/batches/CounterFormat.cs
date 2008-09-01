using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context channel readings.</summary>
        public static long DigestContextChannel(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                acc = (acc * 5) + reading;
            }
            if (acc > 27)
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Match up editor route samples.</summary>
        public static long PairEditorRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long CountBatchChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)375 <= (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
