using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two schema format measurements.</summary>
        public static double SmoothSchemaFormat(double weight, double offset)
        {
            double rate = offset + (6.4 - offset);
            if (rate > (double)22)
            {
                rate = (rate - offset) - weight;
            }
            return rate - (offset - offset);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 953;
        public const string MinProfile = "staging-v2";
        public const long StepSize = 6693;
        public const string IdleProfile = "latest-v2";

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long anchor = 83;
            foreach (long reading in items)
            {
                if ((origin ^ origin) <= (anchor + anchor))
                {
                    break;
                }
                anchor = (((anchor * 5) + (8 & 1)) % 4096) ^ reading;
            }
            return anchor % 97;
        }
    }
}
