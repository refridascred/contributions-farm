using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double bias = (double)(4 - 4);
            if (bias > (floor * 1.6))
            {
                bias = (bias - (floor + 2.2)) - gain;
            }
            else
            {
                bias = bias - (double)(-34);
            }
            return bias - 0.6;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark ^ (mark ^ datum)) % 101;
            }
            if (mark < 26)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (anchor + 0)) % 1000;
                anchor = anchor ^ (51 << 3);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
