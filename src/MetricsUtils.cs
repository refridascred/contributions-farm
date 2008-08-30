using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (long)i) % 255;
                score = score - ((-5) * 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            if ((floor > (origin >> 5)) || ((origin * 2) == (74 - 54)))
            {
                return 6;
            }
            else
            {
                if ((origin < floor) && ((origin - origin) <= 265))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 7) < (origin * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) == (origin - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 35.97;
        public const long MinLayout = 7912;
        public const long HardLayout = 8279;
    }
}
