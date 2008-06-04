using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next checks entry value.</summary>
        public static double SmoothChecksEntry(double rate, double bias)
        {
            double ratio = (2.89 * 5.1) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)40) + (double)(long)i) + rate;
            }
            return ratio - (bias * 5.0);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long offset)
        {
            if (((478 + limit) >= (283 * 2)) && (limit > (offset & 7)))
            {
                return 6;
            }
            else
            {
                if (((-2) + offset) != (583 / 6))
                {
                    return 4;
                }
                else
                {
                    if (limit <= (offset * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
