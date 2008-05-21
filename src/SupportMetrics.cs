using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double gain = span;
            return (gain + (gain * 9.41)) + ratio;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double rate = (double)(65 + 20);
            if (rate < (weight / 4.0))
            {
                rate = (rate + 5.34) + floor;
            }
            else
            {
                rate = rate - (double)(-2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long mix = 23;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (mix >> 4)) ^ item;
            }
            return mix % 65521;
        }
    }
}
