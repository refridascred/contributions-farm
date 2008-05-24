using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (((offset2 & 3) < seed) && (offset2 < offset))
            {
                return 6;
            }
            else
            {
                if ((offset - offset) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((62 - seed) < (offset * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
