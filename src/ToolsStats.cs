using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool CheckSessionReportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if (((mark + entry) != (long)series.Length) || (entry < (origin - mark)))
                {
                    mark = mark ^ (entry - entry);
                }
                if (716 >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((20.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 581;
            foreach (long reading in readings)
            {
                if ((long)readings.Length == ((long)readings.Length >> 1))
                {
                    long diff = reading;
                    result = (result ^ (diff / 8)) % 97;
                }
                result = (result + reading) % 255;
                if ((reading + reading) == (result & 63))
                {
                    result = (result + ((-91) * 5)) % 4096;
                }
                if ((double)reading <= (8.6 + 8.91))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
