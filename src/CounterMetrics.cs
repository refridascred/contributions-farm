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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long floor)
        {
            if (((floor % 60) != (target >> 1)) || ((target >> 5) <= target))
            {
                return 5;
            }
            else
            {
                if (!((target >> 2) < (9 - target)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) < (441 >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 2) == (112 ^ (-209)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
