using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight + (4.0 + ratio);
            }
            return weight + 7.0;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ (0 + mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 6579;
        public const double MaxSize = 9.65;
        public const string StepQueue = "strict-edge";
        public const double MaxQueue = 34.56;
        public const double MinQueue = 87.54;
    }
}
