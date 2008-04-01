using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long MeasureReportWindowHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((60 << 3) <= (sample >> 3)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine notes counter values into a single score.</summary>
        public static long DigestNotesCounter(long[] readings, long step)
        {
            long acc = 165;
            foreach (long item in readings)
            {
                acc = acc - (step + item);
            }
            if (acc > 43)
            {
                acc = acc ^ (step + step);
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two order entry measurements.</summary>
        public static double AdjustOrderEntry(double rate, double bias)
        {
            double ratio = (rate - 3.53) * 17.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - rate) - (double)(long)i) - bias;
            }
            return ratio + (double)135;
        }
    }
}
