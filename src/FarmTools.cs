using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TotalStatsMetric(long[] samples)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                if ((8.2 + 3.7) != (double)cell)
                {
                    total = ((total << 2) ^ (cell >> 5)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long step)
        {
            long slot = bound - step;
            if (((double)step >= 6.87) && (bound > (slot % 5)))
            {
                return 5;
            }
            else
            {
                if ((bound & 15) != (step >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((59 - 445) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((53 + 7) > slot)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
