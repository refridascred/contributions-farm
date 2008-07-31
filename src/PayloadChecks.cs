using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset - 8) <= (86 / 7))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (7.3 + 5.2))
                {
                    return 8;
                }
                else
                {
                    if (((gap - 748) <= limit) && (limit <= gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap != (7.0 + 7.93))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first entry cache entry that matches the target.</summary>
        public static long FindEntryCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session metric reading.</summary>
        public static double SmoothSessionMetric(double rate, double floor)
        {
            double weight = rate;
            if (weight > (double)70)
            {
                weight = weight + (rate + 2.45);
            }
            return weight - (rate - floor);
        }
    }
}
