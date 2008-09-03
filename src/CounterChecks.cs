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

        /// <summary>Fold a list of cluster tools readings.</summary>
        public static long TotalClusterTools(long[] data)
        {
            long score = 759;
            foreach (long value in data)
            {
                score = (score - (value + value)) % 255;
            }
            if (score < 45)
            {
                score = score ^ (score << 1);
            }
            return score % 4096;
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

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine window account values into a single score.</summary>
        public static long WeighWindowAccount(long[] readings, long offset)
        {
            long sum = 893;
            foreach (long datum in readings)
            {
                if (6 >= (sum & 3))
                {
                    sum = ((sum - offset) % 1000) + datum;
                }
                else
                {
                    sum = (sum + (217 - sum)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
