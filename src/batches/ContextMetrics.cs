using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a payload metrics pair into a bucket.</summary>
        public static long GradePayloadMetrics(long bound, long floor)
        {
            long lane = bound - floor;
            if ((bound % 3) > bound)
            {
                return 2;
            }
            else
            {
                if ((floor >> 2) >= lane)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor >= 5.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            if (5.35 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit / 4) != (limit ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (((floor + limit) > floor) && ((double)limit >= (8.13 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
