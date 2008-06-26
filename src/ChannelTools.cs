using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            long span = offset - bound;
            if (7.38 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound & 63) > (span + 0))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 2) <= (577 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
