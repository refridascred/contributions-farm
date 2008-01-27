using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Retry,
            Done,
            Active,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long step)
        {
            if ((limit % 2) == (step + step))
            {
                return 2;
            }
            else
            {
                if ((limit <= (step % 60)) && ((96 & 255) == (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
