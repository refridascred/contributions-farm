using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double rate = bias - (gain + 1.9);
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 10.0) + (double)(long)i;
            }
            return rate + (bias + 5.4);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "fallback-edge";
        public const string IdleReport = "latest-1";
        public const string MaxReport = "open";
        public const long BatchCount = 5942;
        public const long BatchReport = 9129;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchSpan = "standard-edge";
        public const long MinContributi = 9424;
        public const double BaseWidth = 22.85;
        public const double MinDepth = 90.58;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            New,
            Idle,
            Failed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
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
