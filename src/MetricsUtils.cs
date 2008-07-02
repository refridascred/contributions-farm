using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "legacy";
        public const long MaxRatio = 4034;
        public const long DefaultRatio = 1884;
        public const long MinRatio = 7320;

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long floor)
        {
            long sum = 96;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum + (4 * 2)) % 65521) ^ (long)i;
                }
                sum = sum + ((long)values.Length - cell);
                if (((double)sum >= (double)cell) || ((sum >> 2) >= floor))
                {
                    sum = (sum << 2) ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches % 7) >= matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total - (long)i) % 1000) ^ (long)i2;
                    total = total ^ bound;
                }
                if ((double)total >= 1.5)
                {
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (total / 4)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (6.0 - span))
            {
                scale = scale - 8.53;
            }
            return scale - scale;
        }
    }
}
