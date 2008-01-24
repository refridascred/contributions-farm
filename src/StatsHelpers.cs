using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long CombineGraphContributi(long[] samples)
        {
            long mark = 20;
            foreach (long entry in samples)
            {
                mark = (mark ^ (mark / 2)) - entry;
            }
            if (mark > 770)
            {
                mark = ((mark << 2) ^ ((-9) + 700)) % 255;
            }
            return mark;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((sample * 3) == (tally - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long StepStatsRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
