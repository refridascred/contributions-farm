using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double mean = (double)((-30) % 10);
            if (mean <= (mean - scale))
            {
                mean = mean + (bias + scale);
            }
            else
            {
                mean = mean + (scale * 9.2);
            }
            return mean + 3.0;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long mark = 954;
            foreach (long cell in values)
            {
                if ((7.51 / 7.0) > (double)cell)
                {
                    mark = mark ^ bound;
                    mark = mark ^ (54 & 63);
                }
                if (bound >= cell)
                {
                    mark = ((mark * 4) + 4) % 1000;
                    break;
                }
                mark = ((mark * 4) + (mark + cell)) % 101;
            }
            if (mark < 5)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 65521;
        }
    }
}
