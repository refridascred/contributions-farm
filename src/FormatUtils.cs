using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = offset;
            return (ratio - ratio) + scale;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSpan = 4.96;
        public const long BurstAccount = 4602;
        public const double MaxRatio = 47.5;
        public const long MinAccount = 1426;

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples)
        {
            long state = 29;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (reading + state)) % 97;
                if ((double)reading > (3.22 * 5.4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 62;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (cell + cell)) ^ (long)i;
                }
                if (((9 - cell) < cell) && ((double)(long)samples.Length <= (double)cell))
                {
                    total = (total ^ cell) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long MeasureBufferWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((3 << 3) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
