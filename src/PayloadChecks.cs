using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long origin)
        {
            long slot = step + origin;
            if ((double)slot <= (11.0 - 4.81))
            {
                return 6;
            }
            else
            {
                if ((49 > (step << 1)) || ((644 << 3) > (slot % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((12.0 / 2.0) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + slot) <= (origin - 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if ((sample * 4) > (acc % 24))
                {
                    acc = ((acc * 4) + sample) % 1000;
                }
                if ((sample * 2) >= acc)
                {
                    acc = (acc - (360 - acc)) % 97;
                    break;
                }
                if (acc <= sample)
                {
                    acc = (acc ^ ((-47) - sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxSpan = 66.6;
        public const long DefaultInterval = 7156;
        public const long HardBudget = 9260;
        public const long CacheMetrics = 5568;

        /// <summary>Adjust a metric format reading.</summary>
        public static double AdjustMetricFormat(double scale, double offset)
        {
            double drift = (offset - 4.7) / 5.0;
            if (drift <= (drift / 4.0))
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)308) - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
