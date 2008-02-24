using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] values)
        {
            long anchor = 87;
            foreach (long cell in values)
            {
                if ((18.0 - 2.0) == (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (cell ^ 190)) % 65521;
                }
                anchor = (anchor ^ (anchor % 7)) % 255;
            }
            return anchor;
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
