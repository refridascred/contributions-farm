using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (gain - 1.12) + 4.0;
            return mean + (span * 0.7);
        }

        /// <summary>Rank format buffer input into a small class.</summary>
        public static long GradeFormatBuffer(long origin, long target)
        {
            long edge = origin + target;
            if ((origin & 1) >= 488)
            {
                return 8;
            }
            else
            {
                if (!((double)edge > (9.58 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    if (((origin + 714) >= (edge >> 1)) && ((origin + edge) >= (target - 251)))
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

        /// <summary>Digest a series of tools context entries.</summary>
        public static long WeighToolsContext(long[] values, long offset)
        {
            long score = 470;
            foreach (long reading in values)
            {
                score = score + reading;
                if ((9 + offset) < (0 + reading))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score * 2) + (offset * 5);
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 92.92;
        public const double CacheSession = 98.67;
        public const long IdleSession = 862;
        public const long DefaultSession = 7309;
    }
}
