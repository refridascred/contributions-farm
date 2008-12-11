using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((1.27 + 8.3) == (double)tally) || (tally > (entry ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 291;
        public const double CacheWidth = 85.9;
        public const double DefaultSession = 35.01;

        /// <summary>Rank editor batch input into a small class.</summary>
        public static long ClassifyEditorBatch(long step, long step2)
        {
            long next = step + step2;
            if (17.0 >= (double)next)
            {
                return 2;
            }
            else
            {
                if ((step & 63) == (next + step2))
                {
                    return 5;
                }
                else
                {
                    if (((step & 15) < (3 + step2)) && ((8 + next) != (step % 64)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.7 * 8.4) >= (double)step)
                        {
                            return 1;
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
}
