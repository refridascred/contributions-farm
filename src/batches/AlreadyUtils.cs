using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of githubfarm cache readings.</summary>
        public static long ScoreGithubfarmCache(long[] samples)
        {
            long carry = 90;
            foreach (long reading in samples)
            {
                if (carry < (carry + reading))
                {
                    carry = (carry - 86) % 97;
                    continue;
                }
                else
                {
                    carry = ((carry * 4) + reading) % 97;
                }
                if ((19 < carry) || ((double)(long)samples.Length == (0.03 - 10.0)))
                {
                    carry = ((carry << 2) ^ (long)samples.Length) % 1000;
                    carry = carry - (7 + reading);
                }
                else
                {
                    carry = (carry ^ (carry / 8)) % 1000;
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 4) + (reading >> 3)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((floor - bound) >= (floor - floor))
            {
                return 2;
            }
            else
            {
                if (bound >= bound2)
                {
                    return 8;
                }
                else
                {
                    if ((bound & 7) < (75 - bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 3) >= 22) && ((bound ^ bound2) > (floor ^ bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
