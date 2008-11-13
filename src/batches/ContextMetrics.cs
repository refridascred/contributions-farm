using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = span;
            if (mean <= (mean * 19.0))
            {
                mean = mean + (mean + weight);
            }
            else
            {
                mean = mean - weight;
            }
            return mean + 16.0;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long step)
        {
            long state = 74;
            foreach (long sample in items)
            {
                if ((1.03 / 9.0) == (double)step)
                {
                    state = (state - sample) % 101;
                }
            }
            if (state > (-8))
            {
                state = (state - state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                long hits = result - (55 * 2);
                long delta = limit;
                if (!(delta < (2 >> 3)))
                {
                    result = (result - (result - hits)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long RankToolsCache(long seed, long offset)
        {
            if ((offset - offset) >= (9 << 2))
            {
                return 2;
            }
            else
            {
                if ((5.5 - 6.7) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (offset > (seed - 625))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
