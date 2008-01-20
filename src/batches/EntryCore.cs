using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long bound)
        {
            long sum = 85;
            foreach (long value in items)
            {
                sum = (((sum << 2) ^ bound) % 4096) ^ value;
            }
            return sum % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count <= (cell >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long bound, long limit)
        {
            if ((double)bound < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (bound % 12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of metric schema readings.</summary>
        public static long CompareMetricSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            New,
            Closed,
            Paused,
        }
    }
}
