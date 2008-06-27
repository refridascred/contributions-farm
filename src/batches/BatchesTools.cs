using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long step = seed - target;
            if ((step / 5) > target)
            {
                return 2;
            }
            else
            {
                if ((step + step) <= (step - seed))
                {
                    return 1;
                }
                else
                {
                    if ((544 / 5) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + seed) == (seed % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
