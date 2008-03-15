using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long bound)
        {
            long prev = limit - bound;
            if ((prev - limit) >= (limit ^ prev))
            {
                return 2;
            }
            else
            {
                if (!((prev * 3) == (bound / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) < (limit ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound ^ bound) >= prev)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
