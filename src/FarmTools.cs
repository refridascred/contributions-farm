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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long seed)
        {
            long score = 358;
            foreach (long sample in series)
            {
                if (((score >> 5) == (seed + sample)) && ((score ^ 4) == (44 & 15)))
                {
                    score = score ^ (sample + 946);
                }
                if ((double)sample != (double)score)
                {
                    score = (score ^ 768) % 255;
                }
            }
            if (score < 82)
            {
                score = (score << 3) ^ (score % 64);
            }
            return score % 97;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }
    }
}
