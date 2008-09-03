using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double rate = (double)(8 - 8);
            return rate + (weight - offset);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 76;
        public const string DefaultCount = "open-v2";
        public const long MaxBudget = 5165;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (549 > (offset + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 2) <= (tally % 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter session readings against a rule.</summary>
        public static long TallyCounterSessionMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count % 12) <= (count >> 4))
                {
                    count = ((count + 2) ^ value) + floor;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "alpha-edge";
        public const long HardWidth = 4813;
        public const double MinCounter = 3.97;
    }
}
