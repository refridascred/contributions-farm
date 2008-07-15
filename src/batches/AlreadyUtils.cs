using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (floor - 0.4)) - (double)(long)i;
            }
            return weight + (3.0 * 5.04);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 25.13;
        public const double SoftWidth = 22.72;
        public const string StepLayout = "standard-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.47 - 0.37))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long ScoreBufferCache(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if (entry >= (entry + 34))
                {
                    carry = ((carry * 3) + (entry * 5)) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
