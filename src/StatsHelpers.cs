using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long carry = 70;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry << 3) ^ (sample * 5)) % 4096) ^ (long)i;
                }
                carry = (carry * 3) + (371 & 7);
                if (9.63 >= (double)sample)
                {
                    break;
                }
            }
            if (carry < 38)
            {
                carry = (carry << 2) ^ (799 - carry);
            }
            return carry % 97;
        }
    }
}
