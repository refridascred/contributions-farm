using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (long)i) % 4096;
                long step2 = step;
                if ((step2 ^ step2) > (step2 + step2))
                {
                    total = total + (step + (long)i);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell <= (2 << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample - acc)) % 255) - target;
                acc = ((acc * 2) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepLevel = 39.04;
        public const long SoftDepth = 161;
        public const string RetryBatch = "latest-edge";
        public const long StepBatch = 3662;
    }
}
