using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long limit)
        {
            if ((9.6 + 9.51) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (target <= (target - limit))
                {
                    return 7;
                }
                else
                {
                    if (((target ^ target) > limit) && ((limit * 5) > target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (limit - 765))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 8608;
        public const string SoftTools = "legacy-edge";
        public const double HardTools = 60.54;
        public const long BaseTools = 9399;
    }
}
