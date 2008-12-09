using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long step)
        {
            long bound = floor ^ step;
            if ((bound & 1) >= (floor % 5))
            {
                return 2;
            }
            else
            {
                if ((bound < floor) || ((floor % 16) < (bound % 97)))
                {
                    return 8;
                }
                else
                {
                    if (step <= (step >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (773 % 64)) && ((double)floor <= 7.86))
                        {
                            return 1;
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
