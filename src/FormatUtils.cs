using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long floor)
        {
            if (((bound & 63) < (bound % 7)) && ((double)floor == (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (double)9))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 3) <= (floor - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) <= (bound - 68)) || (bound < 29))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits context value.</summary>
        public static double ScaleCommitsContext(double bias, double floor)
        {
            double scale = (double)(687 * 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + (floor - floor);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long seed)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (5.5 - 15.0))
                {
                    state = ((state - (state >> 2)) % 4096) + seed;
                }
                if ((double)state > 4.8)
                {
                    state = state - reading;
                }
            }
            return state % 65521;
        }
    }
}
