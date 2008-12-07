using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two checks profile measurements.</summary>
        public static double ProjectChecksProfile(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio + (ratio * 17.0);
            }
            return ratio + (double)688;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long acc = -6;
            foreach (long reading in samples)
            {
                if ((acc & 1) != (reading << 3))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "standard";
        public const string IdleCommand = "stable";
        public const double CacheInterval = 13.96;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long limit)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if ((double)result == (double)limit)
                {
                    result = ((result << 3) ^ (result + result)) + entry;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result;
        }
    }
}
