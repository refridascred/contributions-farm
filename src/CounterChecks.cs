using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long limit)
        {
            long anchor = 266;
            foreach (long cell in samples)
            {
                anchor = (anchor + (limit & 1)) % 65521;
                if (!((limit << 1) >= (anchor - limit)))
                {
                    anchor = ((anchor << 2) ^ limit) % 101;
                    anchor = (anchor + limit) % 65521;
                }
                if ((long)samples.Length >= limit)
                {
                    anchor = (anchor - anchor) % 97;
                }
                if ((limit + cell) >= (limit % 16))
                {
                    break;
                }
            }
            if (anchor > (-774))
            {
                anchor = anchor - (-43);
            }
            return anchor % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double bias2 = ratio * 5.67;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((0.05 / 7.0) <= (double)item) || !((item << 3) < (item + limit)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
