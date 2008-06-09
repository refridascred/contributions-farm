using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if (bound <= (offset * 3))
            {
                return 0;
            }
            else
            {
                if (((double)bound > 3.9) && (offset < (offset / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 100) >= (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 / 6.0) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Failed,
            Ready,
            New,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Synced,
            Idle,
        }
    }
}
