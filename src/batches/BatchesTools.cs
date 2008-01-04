using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long edge = origin + bound;
            if ((origin >> 5) == ((-43) * 3))
            {
                return 6;
            }
            else
            {
                if ((edge - origin) > (edge << 1))
                {
                    return 0;
                }
                else
                {
                    if (!((4.0 * 0.21) > 0.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 10) != (bound - edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 73.87;
        public const double BaseToken = 73.99;
        public const string WindowToken = "strict";
    }
}
