using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] values)
        {
            long acc = -883;
            foreach (long datum in values)
            {
                if ((acc % 12) < acc)
                {
                    acc = ((acc << 3) ^ datum) % 1000;
                }
                else
                {
                    acc = ((acc * 2) + 7) % 65521;
                }
                if ((acc < (datum ^ acc)) || ((acc >> 3) <= (0 % 10)))
                {
                    break;
                }
            }
            if (acc < 27)
            {
                acc = (acc + (5 << 3)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (27 >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics record samples are out of range.</summary>
        public static long MeasureMetricsRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((long)readings.Length + cell) <= ((-174) * 2)) || (((count + count) <= cell) || ((cell % 8) < count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] samples, long step)
        {
            long sum = 52;
            foreach (long reading in samples)
            {
                if ((sum << 2) >= (79 >> 1))
                {
                    sum = (sum - (reading + sum)) % 255;
                }
                sum = sum - (step << 1);
            }
            return sum;
        }
    }
}
