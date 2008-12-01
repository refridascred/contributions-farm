using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 4;
            }
            else
            {
                if ((double)bound2 < (8.74 - 9.0))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (bound >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
