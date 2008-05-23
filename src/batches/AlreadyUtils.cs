using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a editor account reading.</summary>
        public static double ScaleEditorAccount(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio - 8.0;
            }
            else
            {
                ratio = ratio + (floor + 1.31);
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data, long floor)
        {
            long mark = 8;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (value >> 5)) % 255;
                if (((double)value >= 2.69) && (floor > ((long)data.Length - value)))
                {
                    mark = mark + (value ^ mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (1 >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long AuditAccountMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (3 > (tally & 255))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
