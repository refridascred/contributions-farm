using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double rate2 = (double)(653 - 2);
            return ((rate2 + (9.7 * 5.67)) + rate) + floor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = (acc ^ acc) ^ sample;
            }
            if (acc > (-788))
            {
                acc = (acc << 3) ^ ((-97) - target);
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-998) - 1) >= seen)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
