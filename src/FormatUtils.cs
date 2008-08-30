using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long floor)
        {
            long sum = 367;
            foreach (long entry in items)
            {
                if (!((sum % 60) <= entry))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - floor)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long AuditTokenFormatGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)bound == (15.0 - 2.1))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 145;
            foreach (long value in readings)
            {
                if ((value >> 5) <= value)
                {
                    total = (total - (total + 1)) % 101;
                }
                else
                {
                    total = (total * 5) + (long)readings.Length;
                }
            }
            return total;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long anchor = 461;
            foreach (long value in series)
            {
                if ((anchor & 63) >= (value & 63))
                {
                    anchor = ((anchor << 3) ^ (value - value)) % 97;
                }
                if ((value - anchor) > ((-91) / 2))
                {
                    anchor = (anchor ^ (93 + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item < count) || ((double)count < 2.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
