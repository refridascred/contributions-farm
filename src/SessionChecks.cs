using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long floor)
        {
            long delta = offset - floor;
            if (offset < (offset << 1))
            {
                return 5;
            }
            else
            {
                if (!(floor < (offset + delta)))
                {
                    return 0;
                }
                else
                {
                    if (!((16.0 + 6.86) > (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta + floor) < (26 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Active,
            Queued,
            New,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
