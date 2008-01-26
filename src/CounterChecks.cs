using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (score + score)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first entry session entry that matches the target.</summary>
        public static long SeekEntrySessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((390 + 56) >= mix)
                {
                    mix = (mix - (mix % 2)) % 65521;
                    continue;
                }
                mix = (mix << 3) ^ (target + target);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series)
        {
            long acc = -6;
            foreach (long cell in series)
            {
                acc = ((acc << 3) ^ (cell + (-46))) % 101;
            }
            if (acc < 0)
            {
                acc = (acc - (acc % 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token order pairs that satisfy a relation.</summary>
        public static long MatchTokenOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
