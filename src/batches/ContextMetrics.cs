using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)1 <= (double)offset)
                {
                    acc = (acc - ((long)i ^ acc)) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            long edge = seed + offset;
            if ((seed - edge) <= offset)
            {
                return 5;
            }
            else
            {
                if ((edge << 2) > (9 / 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 8) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7633;
        public const long MinScore = 1437;
        public const long CacheToken = 4252;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double mean = gain / 9.0;
            if (mean >= mean)
            {
                mean = (mean + 8.82) - floor;
            }
            return mean - 4.6;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
