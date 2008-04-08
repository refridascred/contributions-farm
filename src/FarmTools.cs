using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long mix = 25;
            foreach (long value in readings)
            {
                if ((double)mix != (3.3 / 3.0))
                {
                    mix = (mix - (value >> 2)) % 255;
                }
            }
            if (mix < 733)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 50.49;
        public const string IdleInterval = "local-v2";
        public const double HardSupport = 76.0;

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long TallyCounterProfile(long[] samples)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                score = (score * 2) + cell;
                if ((77 / 8) <= score)
                {
                    score = (score ^ (cell * 4)) % 4096;
                }
                else
                {
                    score = (score + (364 + 100)) % 255;
                }
            }
            return score;
        }
    }
}
