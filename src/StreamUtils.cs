using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples)
        {
            long anchor = -72;
            foreach (long item in samples)
            {
                if ((item - anchor) > item)
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            if (anchor > 16)
            {
                anchor = anchor ^ (9 + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long seed)
        {
            if ((1.2 * 4.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)5 < (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((306 % 2) < (seed >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + target) <= (827 << 2)) && ((target & 255) == (target - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleDepth = "strict-v2";
        public const long SoftOrder = 2662;
        public const long BurstOrder = 4021;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
