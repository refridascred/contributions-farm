using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= 302) && ((tally * 3) > (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)step < (7.0 + 17.0))
            {
                return 0;
            }
            else
            {
                if (step < (step + 0))
                {
                    return 2;
                }
                else
                {
                    if (((seed + step) > (seed % 3)) || (((-17) % 8) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur / 4) == (seed - seed)) && ((cur << 3) > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const long HardContributi = 9923;
        public const string BatchContributi = "open-v2";
    }
}
