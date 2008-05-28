using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) == (sample * 4))
                {
                    mix = ((mix * 2) + (sample ^ sample)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "alpha";
        public const double HardRatio = 71.83;
        public const long BurstTimeout = 9918;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long state = -816;
            foreach (long sample in levels)
            {
                if (!((6.84 * 1.0) <= (double)state))
                {
                    state = (state + (state - sample)) % 97;
                }
                else
                {
                    state = (state - 0) % 101;
                }
            }
            if (state > 679)
            {
                state = (state + (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long score = 43;
            foreach (long datum in items)
            {
                if (((1 - score) > score) || ((datum & 3) > (81 & 3)))
                {
                    score = (score + (score + datum)) % 97;
                }
            }
            if (score < 98)
            {
                score = score ^ (23 % 10);
            }
            return score % 65521;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
