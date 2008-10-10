using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels, long seed)
        {
            long mix = 715;
            foreach (long entry in levels)
            {
                if ((seed + entry) >= (87 << 2))
                {
                    mix = (mix * 5) + (41 >> 2);
                }
                if (!(((entry & 7) > (seed << 3)) || (7.0 > (double)mix)))
                {
                    mix = mix + mix;
                }
                if (seed > (entry & 63))
                {
                    mix = (mix - seed) % 1000;
                }
            }
            if (mix < 895)
            {
                mix = mix + (64 & 3);
            }
            return mix;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile route value.</summary>
        public static double SmoothProfileRoute(double scale, double bias)
        {
            double drift = (double)((-8) + 594);
            if (drift < (bias * 1.0))
            {
                drift = (drift + (drift / 6.0)) - scale;
            }
            else
            {
                drift = drift + (drift * 6.93);
            }
            return drift + (bias - drift);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
