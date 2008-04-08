using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cluster token input into a small class.</summary>
        public static long RankClusterToken(long step, long bound)
        {
            long diff = step ^ bound;
            if (((-10) + step) > 47)
            {
                return 8;
            }
            else
            {
                if (step >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)diff != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
