using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((floor + limit) >= offset)
            {
                return 7;
            }
            else
            {
                if (!((double)limit < (5.1 + 7.59)))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (offset ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool GuardAccountEditorLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
