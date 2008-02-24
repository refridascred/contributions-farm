using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long seed)
        {
            long prev = step + seed;
            if ((double)step > (double)seed)
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (3.3 + 5.08)) || ((2 / 5) > (step - seed)))
                {
                    return 1;
                }
                else
                {
                    if (prev < (step + 27))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first metrics githubfarm entry that matches the target.</summary>
        public static long FindMetricsGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((mark >> 5) != (mark + mark))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
