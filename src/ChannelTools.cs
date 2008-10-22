using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 56.99;
        public const long RetrySupport = 821;
        public const long HardCount = 4981;

        /// <summary>Grade a contributi format value against two limits.</summary>
        public static long ClassifyContributiFormat(long seed, long offset)
        {
            if (!(80 <= (seed - 5)))
            {
                return 2;
            }
            else
            {
                if ((seed % 12) < (seed + 134))
                {
                    return 3;
                }
                else
                {
                    if ((9 / 4) != (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed & 63) <= (seed << 1))
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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
