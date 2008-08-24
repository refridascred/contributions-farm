using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) + gain;
            }
            return ratio + (double)6;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a commits channel value against two limits.</summary>
        public static long SortCommitsChannel(long seed, long step)
        {
            long span = seed - step;
            if ((span - step) != (seed % 16))
            {
                return 7;
            }
            else
            {
                if ((step & 15) > step)
                {
                    return 3;
                }
                else
                {
                    if ((double)6 >= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.0 * 15.0) >= (double)span)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
