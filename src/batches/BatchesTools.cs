using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            long lane = seed - origin;
            if ((seed - lane) < seed)
            {
                return 5;
            }
            else
            {
                if ((origin % 60) != (lane * 4))
                {
                    return 1;
                }
                else
                {
                    if ((lane / 3) <= (lane << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-65) + seed) < (lane * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
