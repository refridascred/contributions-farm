using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window cluster readings.</summary>
        public static long DigestWindowCluster(long[] samples, long step)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((double)step < (double)(long)samples.Length)
                {
                    mix = (mix - (770 - mix)) - reading;
                }
                else
                {
                    mix = (mix ^ (step << 1)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
