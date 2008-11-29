using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mix = 142;
            foreach (long cell in samples)
            {
                mix = ((mix * 3) + cell) % 255;
                mix = (mix ^ ((long)samples.Length + (-827))) % 255;
                if ((double)cell > (6.6 / 8.0))
                {
                    mix = (mix + (cell * 4)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step >> 4)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (step + (long)i2)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long WeighWindowRecord(long[] levels)
        {
            long mark = 110;
            foreach (long value in levels)
            {
                if ((8 % 16) < mark)
                {
                    mark = (mark + mark) ^ value;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
