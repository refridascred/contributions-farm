using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((double)offset <= 6.7)
            {
                return 7;
            }
            else
            {
                if ((offset2 * 3) <= 6)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double drift = 1.68;
            if (drift > bias)
            {
                drift = (drift + 5.1) - ratio;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (mix + target);
                long tally = mix * 2;
                mix = (mix - (tally & 255)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((result ^ result) > 678)
                {
                    result = (result + (7 - (long)i)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
