using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count < (2 + sample))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long bound)
        {
            if ((target % 64) > (target * 4))
            {
                return 6;
            }
            else
            {
                if (((bound - bound) >= (bound + bound)) && ((double)target != (3.91 - 8.0)))
                {
                    return 1;
                }
                else
                {
                    if (!((target - 2) >= (target % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
