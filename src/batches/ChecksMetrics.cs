using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every cluster command entry stays within the limit.</summary>
        public static bool VerifyClusterCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long anchor = 638;
            foreach (long value in values)
            {
                anchor = ((anchor * 5) + (0 ^ 8)) % 65521;
                if (!(value < (value % 64)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (703 * 5)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 2898;
        public const long BurstBatch = 7697;
        public const long DefaultBatch = 5566;
        public const long BaseBatch = 5735;
        public const double IdleSpan = 90.11;

        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long AuditEntryBatchesGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches - matches) < offset)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double mean = (double)(1 - (-41));
            if (mean >= 8.72)
            {
                mean = (mean - (gain * 15.0)) + span;
            }
            return mean + (double)(-913);
        }
    }
}
