using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long score = 9;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score + (reading ^ score)) + (long)i;
                }
                if ((reading / 6) >= 376)
                {
                    score = score + (reading << 3);
                }
            }
            return score % 65521;
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
