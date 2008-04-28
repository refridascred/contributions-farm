using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long origin)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                if (acc <= (acc << 2))
                {
                    acc = ((((acc * 5) + acc) % 101) + entry) + origin;
                }
            }
            if (acc > (-67))
            {
                acc = ((acc << 3) ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Derive the next route support value from a seed.</summary>
        public static long IterateRouteSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (8.9 < (double)(long)i)
                {
                    carry = carry ^ floor;
                }
                if (((floor << 1) <= floor) || ((long)i > carry))
                {
                    carry = (carry - (floor ^ carry)) % 1000;
                    carry = carry - (carry & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ (carry + carry)) % 255) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 845;
            foreach (long value in levels)
            {
                if ((value << 1) <= (value + value))
                {
                    score = ((score * 4) + (value / 6)) % 101;
                    score = (score * 2) + (score >> 5);
                }
                else
                {
                    score = (score - 0) % 255;
                }
                if (value >= (value + value))
                {
                    score = (score - (value + (-274))) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count <= (item + item)) || ((double)item >= (5.9 - 4.82)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches % 8) <= matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
