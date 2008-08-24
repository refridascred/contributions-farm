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

        /// <summary>Accumulate filter payload samples.</summary>
        public static long DigestFilterPayload(long[] readings)
        {
            long mix = 35;
            foreach (long value in readings)
            {
                mix = (mix - (mix << 2)) % 97;
                if (value < (4 ^ 253))
                {
                    mix = ((mix * 4) + (value - mix)) % 97;
                }
            }
            if (mix > (-2))
            {
                mix = mix + mix;
            }
            return mix % 1000;
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
