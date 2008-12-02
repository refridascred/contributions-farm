using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long bound)
        {
            long acc = 711;
            foreach (long reading in series)
            {
                if ((10.0 * 3.12) == (double)acc)
                {
                    acc = ((acc ^ (acc ^ 11)) % 1000) + reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound / 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long diff = bound ^ target;
            if ((4.7 * 20.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((8.0 / 2.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(5.7 <= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long bound)
        {
            if ((bound - bound) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if (!((floor + 0) >= (floor - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - 29) <= (8 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = -6;
            foreach (long value in series)
            {
                sum = ((sum * 4) + value) % 97;
                if (((sum << 2) != (value >> 2)) && (((-7) + sum) < (long)series.Length))
                {
                    break;
                }
            }
            if (sum < 542)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }
    }
}
