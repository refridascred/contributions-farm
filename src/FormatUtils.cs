using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile filter samples.</summary>
        public static long TotalProfileFilter(long[] values)
        {
            long sum = 378;
            foreach (long cell in values)
            {
                double mean = (2.72 - 7.0) - (double)(long)values.Length;
                if (((mean * 2.34) <= mean) || (mean >= 8.29))
                {
                    mean = (mean + (double)554) + (double)cell;
                    break;
                }
                sum = sum - 5;
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long floor)
        {
            long anchor = 61;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor + ((long)i & 63)) % 65521) + reading;
                    anchor = ((anchor * 2) + (floor + (long)i)) % 1000;
                }
                if ((anchor - 48) <= (floor >> 4))
                {
                    anchor = (anchor * 5) + (32 % 24);
                }
            }
            if (anchor < 7)
            {
                anchor = anchor - (floor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
