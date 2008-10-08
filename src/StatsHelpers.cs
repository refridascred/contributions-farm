using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double ratio = (18.0 + 3.0) - (bias / 9.0);
            if (ratio <= (bias / 2.0))
            {
                ratio = (ratio - (ratio - ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            if ((limit * 4) <= (bound % 16))
            {
                return 5;
            }
            else
            {
                if (!((limit ^ bound) < (bound / 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound ^ bound) >= (limit - 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
