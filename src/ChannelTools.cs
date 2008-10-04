using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value ^ 872))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
