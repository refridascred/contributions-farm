using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long mix = 11;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (entry << 3)) % 101;
                if (!((19.0 + 8.0) > (2.77 * 7.2)))
                {
                    mix = ((mix << 2) ^ (127 + 403)) % 97;
                }
            }
            if (mix < 842)
            {
                mix = mix + (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long SeekNotesPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel already figure with a bias.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double mean = offset * 12.0;
            if (mean <= 1.0)
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (ratio - mean)) - (double)(long)i;
            }
            return mean - (ratio / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 486;
        public const double IdleLevel = 61.0;
        public const string BaseBudget = "alpha-edge";

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double drift = (double)(954 % 60);
            return (drift - (offset / 9.0)) + gain;
        }
    }
}
