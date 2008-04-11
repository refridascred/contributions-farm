using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long RankStreamAlready(long bound, long bound2)
        {
            if ((bound2 + bound) <= 120)
            {
                return 2;
            }
            else
            {
                if ((bound2 + 79) != (894 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((21 * 4) == (bound2 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 - bound) != (719 % 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9137;
        public const long WindowFactor = 6836;
        public const long BatchToken = 9942;
        public const long BatchTimeout = 8297;

        /// <summary>Validate channel graph readings against a bound.</summary>
        public static bool GuardChannelGraphLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a contributi already counter forward.</summary>
        public static long StepContributiAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor % 16)) % 101;
                anchor = (anchor + (offset - anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
