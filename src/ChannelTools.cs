using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double SmoothContextEntry(double rate, double offset)
        {
            double mean = offset;
            if (mean < (offset * 0.18))
            {
                mean = (mean + offset) - rate;
            }
            return mean + (offset + offset);
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer githubfarm series from a seed.</summary>
        public static long DeriveBufferGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
