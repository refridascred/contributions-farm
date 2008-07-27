using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long limit)
        {
            if ((offset + offset) < (offset + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 4) >= offset))
                {
                    return 6;
                }
                else
                {
                    if (!((offset - limit) > limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.29 - 1.2) <= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8542;
        public const long HardFactor = 6786;
        public const double CacheEntry = 64.22;
        public const string BurstTimeout = "primary-v2";

        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long StepGithubfarmWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the batches layout entries that pass the check.</summary>
        public static long TallyBatchesLayoutHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen <= sample) || (((floor + floor) >= (sample - floor)) || ((seen ^ seen) > (sample ^ floor))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
