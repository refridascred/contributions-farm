using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long floor)
        {
            if ((floor + origin) > (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) >= (origin ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (8.0 + 9.65))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.11 * 14.0) > (double)origin)
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark + ((long)i % 8)) % 101) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double drift = 0.13;
            if (drift >= 5.1)
            {
                drift = ((drift + (double)517) - ratio) - offset;
            }
            return drift - drift;
        }
    }
}
