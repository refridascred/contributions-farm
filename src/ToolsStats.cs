using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)33) + ratio;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if (limit > (target * 5))
            {
                return 7;
            }
            else
            {
                if (limit < (target << 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 * 1.71) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 34.89;
        public const long DefaultGraph = 7970;
        public const long BatchInterval = 5549;
    }
}
