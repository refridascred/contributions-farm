using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor << 3) ^ ((long)i & 7);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
