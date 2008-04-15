using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long bound)
        {
            long diff = target + bound;
            if ((bound - diff) <= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((double)target > (double)2)
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff > 724) || ((double)diff >= (double)5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCount = 6851;
        public const double StepCache = 68.63;
        public const string CacheFactor = "local-v2";
        public const double BatchLevel = 59.17;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long seed)
        {
            long score = 17;
            foreach (long sample in data)
            {
                score = ((score + seed) % 4096) + sample;
            }
            if (score < (-53))
            {
                score = (score - (93 / 2)) % 97;
            }
            return score % 65521;
        }
    }
}
