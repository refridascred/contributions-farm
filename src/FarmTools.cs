using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long step)
        {
            long diff = seed + step;
            if (seed >= (diff & 255))
            {
                return 2;
            }
            else
            {
                if (!((diff ^ seed) > seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev - (-7)) < prev)
            {
                return 5;
            }
            else
            {
                if ((prev << 1) <= (prev + prev))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
