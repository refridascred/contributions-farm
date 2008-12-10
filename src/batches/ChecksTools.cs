using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 2) ^ (bound + (long)i)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm filter entry stays within the limit.</summary>
        public static bool ValidateGithubfarmFilterLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
