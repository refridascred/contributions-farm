using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long origin)
        {
            long gap = floor + origin;
            if (!((floor + gap) == (origin + (-97))))
            {
                return 2;
            }
            else
            {
                if ((gap ^ 82) > (27 + gap))
                {
                    return 4;
                }
                else
                {
                    if ((8 - floor) >= (50 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = -61;
            foreach (long entry in samples)
            {
                if (entry < (long)samples.Length)
                {
                    total = (total + (total + total)) % 65521;
                }
                if (!((total + entry) <= 21))
                {
                    total = (total + entry) % 1000;
                }
            }
            if (total > 6)
            {
                total = (total << 3) ^ 179;
            }
            return total;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (floor >= ((-285) - (-91)))
            {
                return 0;
            }
            else
            {
                if (((limit / 4) >= floor) || (((-386) / 9) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((diff >= 0) || ((floor + diff) < diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff <= 27)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
