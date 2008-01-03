using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((684 ^ seen) == (741 & 63))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((bound >> 1) <= (43 << 1))
                {
                    long hits = bound;
                    mix = ((mix << 2) ^ (hits << 1)) % 101;
                }
                if ((mix << 1) < item)
                {
                    mix = (mix + bound) % 4096;
                }
            }
            return mix;
        }
    }
}
