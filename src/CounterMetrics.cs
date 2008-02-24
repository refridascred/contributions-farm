using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen * 2) == (seen & 255)) || ((4.98 + 8.47) == (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
