using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] items)
        {
            long acc = 674;
            foreach (long value in items)
            {
                if ((446 >> 5) > acc)
                {
                    acc = ((acc * 2) + (36 * 4)) % 101;
                }
                else
                {
                    acc = (acc - (value - acc)) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc + (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + item) < 60)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = -82;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (mix / 9)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
