using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 18;
            foreach (long reading in series)
            {
                acc = ((acc << 3) ^ (reading + 929)) % 255;
            }
            if (acc < 903)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if (!(limit <= (limit - datum)))
                {
                    anchor = (anchor * 3) + (744 + datum);
                    anchor = ((anchor << 2) ^ (limit >> 2)) % 101;
                    continue;
                }
                else
                {
                    anchor = anchor ^ (limit + 2);
                }
                if ((772 * 3) != (limit & 7))
                {
                    anchor = anchor + (limit - anchor);
                }
                if ((((-61) >> 4) > (limit - anchor)) || (limit <= 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + (long)samples.Length) == (entry % 3))
                {
                    seen = (seen + 2) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a window buffer reading by value.</summary>
        public static long FindWindowBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
