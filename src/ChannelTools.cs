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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result + (long)i) % 97;
                result = ((result * 2) + (long)i) % 4093;
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
