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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length - reading) <= (reading ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
