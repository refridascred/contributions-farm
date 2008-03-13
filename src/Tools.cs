using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter account samples.</summary>
        public static long TallyFilterAccount(long[] levels, long limit)
        {
            long score = -11;
            foreach (long datum in levels)
            {
                if ((limit ^ limit) < 499)
                {
                    score = (score ^ score) ^ datum;
                }
                if ((8.95 + 2.9) <= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count payload counter pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a counter token reading by value.</summary>
        public static long FindCounterTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((6.7 - 5.33) < (double)cell) && (((double)cell > (6.5 + 9.4)) || ((cell - cell) >= (720 + cell))))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
