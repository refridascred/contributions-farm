using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = -5;
            foreach (long sample in readings)
            {
                mix = ((mix - (mix >> 3)) % 97) - sample;
                if ((double)mix <= (1.6 - 14.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long seed2)
        {
            long span = seed + seed2;
            if ((double)seed != (2.33 / 9.0))
            {
                return 8;
            }
            else
            {
                if ((double)seed2 > (14.0 * 3.2))
                {
                    return 5;
                }
                else
                {
                    if (!((span >> 4) >= 587))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed2 - seed) > seed2) || ((0 - 6) == (span ^ (-8))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
