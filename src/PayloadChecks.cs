using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double bias2 = 14.0;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + 6.3) + (double)(long)i) + bias;
            }
            return bias2 - rate;
        }

        /// <summary>Classify a schema queue pair into a bucket.</summary>
        public static long SortSchemaQueue(long limit, long offset)
        {
            if ((limit / 3) < 692)
            {
                return 4;
            }
            else
            {
                if (4.23 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((seed * 3) < (seed & 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
