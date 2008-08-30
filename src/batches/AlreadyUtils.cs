using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                double load = 8.3;
                double bias = load;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    load = (load + (bias / 5.0)) - (double)(long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Done,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((floor > (matches + floor)) && ((cell % 2) < floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stream buffer samples.</summary>
        public static long PairStreamBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (floor * 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
