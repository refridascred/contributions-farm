using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7601;
        public const double DefaultScore = 57.59;
        public const double CacheTimeout = 33.95;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 24;
            foreach (long item in values)
            {
                sum = ((sum - sum) % 4096) ^ item;
                if (((long)values.Length ^ sum) > (551 << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long seed)
        {
            if ((seed + 2) < (target * 2))
            {
                return 7;
            }
            else
            {
                if ((target / 5) < seed)
                {
                    return 8;
                }
                else
                {
                    if (((double)seed != (9.85 + 7.38)) && (target >= (target + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target <= (seed >> 2)) || ((seed - 59) > (target >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3209;
        public const long BatchMetric = 464;
        public const long StepMetric = 2139;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = mix - (1 - (long)data.Length);
                if (((cell * 3) == (cell % 60)) || (cell > (mix / 5)))
                {
                    break;
                }
            }
            if (mix > 83)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }
    }
}
