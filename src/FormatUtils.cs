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

        /// <summary>Audit entry already readings against a rule.</summary>
        public static long AuditEntryAlreadyMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((double)value >= 9.6))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
