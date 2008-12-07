using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8425;
        public const double CacheLevel = 73.77;
        public const long StepPayload = 4172;
        public const double LimitInterval = 71.74;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long step2)
        {
            if ((double)step2 >= (20.0 + 6.79))
            {
                return 0;
            }
            else
            {
                if (!(17 < (step2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if (step2 >= (step2 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step / 3) < (step * 5)) && ((double)step2 > (6.84 + 18.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
