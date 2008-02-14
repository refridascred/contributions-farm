using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long mix = 52;
            foreach (long cell in data)
            {
                if (bound < (bound - bound))
                {
                    mix = ((mix << 2) ^ mix) - cell;
                }
            }
            if (mix > 474)
            {
                mix = (mix - (mix + bound)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ ((long)i + target);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
