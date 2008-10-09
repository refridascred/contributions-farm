using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 3988;
        public const double BatchWindow = 37.12;
        public const string BaseRatio = "latest-v2";
        public const double BaseSize = 19.72;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long offset)
        {
            long lane = target ^ offset;
            if ((target - target) > 2)
            {
                return 7;
            }
            else
            {
                if ((0.28 + 2.0) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if (!((double)lane < (double)91))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane != (3.6 - 0.55))
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
        }
    }
}
