using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "alpha-1";
        public const long StepDepth = 7251;
        public const long HardLevel = 4441;
        public const long HardSpan = 2345;
        public const long DefaultPayload = 4434;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data)
        {
            long acc = 351;
            foreach (long entry in data)
            {
                if (!((acc << 1) == (entry << 3)))
                {
                    acc = ((acc * 3) + (entry - entry)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (719 ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double mean = floor;
            return (mean - 2.09) + ratio;
        }
    }
}
