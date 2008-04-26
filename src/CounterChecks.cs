using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((offset + gap) != (offset / 6))
            {
                return 6;
            }
            else
            {
                if (offset2 < ((-40) - offset))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = offset;
            return (gain + 8.85) + scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 719;
            foreach (long cell in items)
            {
                if ((double)cell == (double)sum)
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
                else
                {
                    sum = (sum - (cell % 100)) % 101;
                }
            }
            if (sum < 593)
            {
                sum = (sum - (sum * 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long target)
        {
            if (((target - target) >= target) || (629 > (offset + offset)))
            {
                return 1;
            }
            else
            {
                if ((target * 2) > target)
                {
                    return 7;
                }
                else
                {
                    if (target < (39 >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
