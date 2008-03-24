using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a window channel reading by value.</summary>
        public static long SeekWindowChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 61;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (sample >> 3)) % 4096) ^ (long)i;
                    mix = (mix + (sample / 6)) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix * 2) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (sample + 728)) % 255;
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
