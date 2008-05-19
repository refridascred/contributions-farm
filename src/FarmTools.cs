using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 670;
            foreach (long sample in readings)
            {
                if ((sample - 42) > (57 * 3))
                {
                    mix = mix ^ (sample / 7);
                }
                else
                {
                    mix = mix - (sample - sample);
                }
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long CountCommitsStatsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < (reading - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
