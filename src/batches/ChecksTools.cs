using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (!((double)value < (4.7 - 4.28)))
                {
                    mix = (mix + (666 << 1)) - seed;
                    break;
                }
                mix = (mix ^ (8 - value)) % 255;
                mix = mix + 57;
            }
            if (mix > 19)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Validate githubfarm buffer readings against a bound.</summary>
        public static bool ValidateGithubfarmBufferLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double drift = 3.2;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (double)754) - (double)(long)i) - bias;
            }
            return drift + gain;
        }
    }
}
