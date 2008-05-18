using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 9988;
        public const string MaxInterval = "standard-v2";
        public const long MaxSession = 6827;

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double span)
        {
            double mean = span + span;
            if (mean <= span)
            {
                mean = (mean + span) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean + span);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2.0 - 9.62) >= (double)cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
