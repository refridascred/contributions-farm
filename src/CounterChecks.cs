using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series)
        {
            long score = 30;
            foreach (long sample in series)
            {
                score = score ^ sample;
                if ((sample << 2) > (score << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (matches << 3))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = (double)(269 + 46);
            if (scale < 11.0)
            {
                scale = (scale - 7.5) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double rate = (double)((-50) / 4);
            if (rate >= (rate / 9.0))
            {
                rate = (rate - rate) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + 14.0;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long bound)
        {
            if (origin >= (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((double)origin != (2.2 * 4.8))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ bound) < (origin - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm cache samples.</summary>
        public static long CompareGithubfarmCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
