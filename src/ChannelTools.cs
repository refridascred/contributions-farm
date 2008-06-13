using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long origin)
        {
            if (origin >= (target * 2))
            {
                return 5;
            }
            else
            {
                if (!(origin <= (target - target)))
                {
                    return 1;
                }
                else
                {
                    if ((17.0 * 1.05) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + target) > (origin + 616))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 63.33;
        public const string BaseSpan = "local";
        public const long WindowCount = 7379;
        public const long LimitCount = 3691;
    }
}
