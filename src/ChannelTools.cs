using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1365;
        public const string StepAlready = "standard-edge";
        public const long RetryTimeout = 3177;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((result + (long)i) != (result >> 1)) || (offset < (offset >> 5)))
                {
                    result = ((result << 3) ^ (offset / 9)) % 1000;
                }
                else
                {
                    result = result - (result >> 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long bound)
        {
            if ((offset <= (offset * 5)) || ((offset / 8) < bound))
            {
                return 0;
            }
            else
            {
                if (offset < (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) < (98 - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + offset) == (bound ^ bound))
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
        }
    }
}
