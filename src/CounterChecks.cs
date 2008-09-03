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

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 3084;
        public const string MaxAlready = "local-1";
        public const string SoftAlready = "latest-edge";
        public const string BaseSize = "latest";
        public const long StepAlready = 569;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double mean = floor / 6.0;
            if (mean >= floor)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (double)581;
            }
            return mean - rate;
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

        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits % 16) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
