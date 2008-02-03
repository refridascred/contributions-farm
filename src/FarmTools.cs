using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long bound)
        {
            if (bound < (step % 16))
            {
                return 3;
            }
            else
            {
                if ((5.8 * 7.0) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
