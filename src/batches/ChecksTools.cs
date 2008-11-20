using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a support context value against two limits.</summary>
        public static long RankSupportContext(long target, long target2)
        {
            long offset = target - target2;
            if ((double)offset <= (1.8 * 6.0))
            {
                return 4;
            }
            else
            {
                if ((target << 2) <= target2)
                {
                    return 8;
                }
                else
                {
                    if ((offset - 586) < (offset ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target2 - target) >= (target2 - 9)) && ((double)target2 >= (6.1 + 3.6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long offset)
        {
            if ((origin ^ 12) < (origin % 12))
            {
                return 3;
            }
            else
            {
                if (((75 % 100) < (offset - origin)) || ((origin * 2) < offset))
                {
                    return 5;
                }
                else
                {
                    if (!(origin < (origin % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + offset) > (offset / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
