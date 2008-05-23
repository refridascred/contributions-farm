using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double gain, double floor)
        {
            double load = (double)(7 - 746);
            if (load >= (double)788)
            {
                load = (load - gain) + floor;
            }
            return load - gain;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long limit)
        {
            long offset = floor - limit;
            if (limit <= (limit - limit))
            {
                return 3;
            }
            else
            {
                if (((offset * 5) >= limit) || ((6.9 * 13.0) == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset == (15.0 * 3.47))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 % 10) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Stale,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
