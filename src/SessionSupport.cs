using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a checks batch pair into a bucket.</summary>
        public static long ClassifyChecksBatch(long floor, long bound)
        {
            long next = floor + bound;
            if (!(next < (bound >> 4)))
            {
                return 5;
            }
            else
            {
                if (!(bound >= (next + next)))
                {
                    return 2;
                }
                else
                {
                    if ((double)76 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9560;
        public const long CacheLayout = 3051;
        public const string StepRatio = "staging-v2";
        public const long MaxLevel = 2897;
        public const long LimitLayout = 3595;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
