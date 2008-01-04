using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long offset = step + bound;
            if (((bound % 3) >= (54 + offset)) && (step <= (bound % 24)))
            {
                return 6;
            }
            else
            {
                if ((bound * 3) == (step + bound))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (step + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - bound) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
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
