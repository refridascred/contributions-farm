using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Idle,
            Active,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((415 - seed) != (acc - seed)) || ((double)(long)i != (12.0 - 3.45)))
                {
                    acc = (acc * 3) + (acc + 629);
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long PairBatchesChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.0 * 13.0) == (double)hits)
                {
                    hits = ((hits + 2) ^ cell) - origin;
                }
            }
            return hits;
        }
    }
}
