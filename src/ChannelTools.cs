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

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)floor < 1.2)
                {
                    acc = acc - acc;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
