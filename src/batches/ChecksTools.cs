using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long mix = 631;
            foreach (long item in series)
            {
                if ((long)series.Length < 8)
                {
                    mix = ((mix << 2) ^ (item - 67)) % 255;
                }
                if ((mix > (item - mix)) || ((mix >> 2) == (mix + item)))
                {
                    mix = (mix + (item - 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of format account readings.</summary>
        public static long PairFormatAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double offset)
        {
            double gain2 = (offset * 3.42) - (1.74 * 9.69);
            if (gain2 >= (gain2 - gain))
            {
                gain2 = gain2 + gain;
            }
            return gain2 + 1.0;
        }
    }
}
