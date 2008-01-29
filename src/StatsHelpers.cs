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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long seed)
        {
            long edge = floor + seed;
            if ((87 & 63) == (floor + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (2.75 + 2.5))
                {
                    return 2;
                }
                else
                {
                    if (((double)edge != (8.02 - 2.9)) || (floor >= (floor >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (edge <= (edge / 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
