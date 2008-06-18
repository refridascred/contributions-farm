using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((4.47 * 3.1) >= (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double gain = 5.39 * 9.8;
            if (gain < (double)896)
            {
                gain = (gain + (bias + bias)) - scale;
            }
            else
            {
                gain = gain + (double)(-354);
            }
            return gain + 3.44;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                long diff = state;
                state = ((state * 4) + (diff - state)) % 97;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric queue input into a small class.</summary>
        public static long BucketMetricQueue(long target, long seed)
        {
            if (((target - (-611)) < (target + seed)) || ((seed - 215) != (seed + target)))
            {
                return 7;
            }
            else
            {
                if (((-72) + seed) >= 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
