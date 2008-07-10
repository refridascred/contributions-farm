using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                sum = (sum ^ (value + value)) % 97;
                if (!(sum >= (value - sum)))
                {
                    sum = (sum * 5) + (value / 2);
                }
                if (((sum + value) > value) || ((3.06 - 8.3) != (double)value))
                {
                    break;
                }
            }
            if (sum < 594)
            {
                sum = ((sum * 2) + 188) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items, long target)
        {
            long mark = 834;
            foreach (long sample in items)
            {
                mark = ((mark * 5) + (mark * 2)) - target;
                if ((18 >> 3) == (226 + sample))
                {
                    mark = (mark - (sample * 5)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 809;
            foreach (long datum in readings)
            {
                score = score ^ (datum - datum);
            }
            if (score < 75)
            {
                score = score ^ (score ^ score);
            }
            return score % 1000;
        }
    }
}
