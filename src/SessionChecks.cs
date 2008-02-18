using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank account token input into a small class.</summary>
        public static long GradeAccountToken(long floor, long limit)
        {
            long diff = floor + limit;
            if (((floor + floor) < 83) || ((floor - diff) > (8 * 5)))
            {
                return 8;
            }
            else
            {
                if ((limit * 2) <= (7 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor > (0.6 * 8.4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
