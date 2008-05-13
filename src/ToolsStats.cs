using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long AuditRecordLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 2) != (1 << 2))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry commits entries.</summary>
        public static long TallyEntryCommits(long[] values)
        {
            long mark = 16;
            foreach (long value in values)
            {
                if ((13 + mark) < (value % 7))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
                else
                {
                    mark = (mark - (value + (-141))) % 4096;
                }
            }
            if (mark > 593)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6270;
        public const long MaxFactor = 8681;
        public const long StepLayout = 4624;
        public const double StepSpan = 31.65;
        public const double BaseLayout = 22.87;

        /// <summary>Accumulate context metric samples.</summary>
        public static long CombineContextMetric(long[] data, long floor)
        {
            long result = 21;
            foreach (long item in data)
            {
                if (result < ((long)data.Length << 3))
                {
                    result = (((result * 5) + (345 >> 4)) % 97) - floor;
                }
                if ((item << 3) > (result & 3))
                {
                    result = ((result * 2) + (599 >> 5)) % 4096;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - value) == (value >> 1))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
