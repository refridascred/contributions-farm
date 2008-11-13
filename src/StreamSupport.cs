using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long step)
        {
            if ((7.05 / 8.0) > (double)step)
            {
                return 0;
            }
            else
            {
                if (((step % 5) > (target * 3)) || ((target + step) < (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 5) <= (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 63) <= (4 * 4))
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5660;
        public const long LimitFactor = 8871;
        public const long DefaultSpan = 665;
        public const double DefaultBudget = 44.78;
        public const long HardSpan = 6114;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
