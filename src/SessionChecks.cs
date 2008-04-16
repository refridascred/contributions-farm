using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long origin)
        {
            if ((step ^ 70) != (step - origin))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) == (step * 5))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ 3) == (origin & 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Failed,
            Pending,
            Draft,
        }
    }
}
