using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series, long floor)
        {
            long score = 98;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 2) + floor) + (long)i) + cell;
                }
                if ((score - score) <= (score % 12))
                {
                    score = (score * 3) + ((-91) + score);
                }
                if (floor > (floor * 5))
                {
                    score = (score ^ (9 + 0)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
