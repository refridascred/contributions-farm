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

        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long TallyContributiMetricHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((278 - tally) < (target - sample)) || ((sample * 5) < (target >> 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
