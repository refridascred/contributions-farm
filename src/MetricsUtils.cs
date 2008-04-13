using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] samples, long step)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                if (!((sample / 9) >= (result << 3)))
                {
                    result = (result + (2 + step)) % 101;
                }
                result = (result - sample) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + (long)data.Length) > (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long offset)
        {
            long mark = -5;
            foreach (long reading in readings)
            {
                if (((reading + mark) >= reading) || ((7.24 / 9.0) != (double)mark))
                {
                    mark = (mark ^ (mark % 7)) + offset;
                }
                if ((reading / 6) == (reading % 5))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
