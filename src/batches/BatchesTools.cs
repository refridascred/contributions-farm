using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Classify a token profile pair into a bucket.</summary>
        public static long GradeTokenProfile(long offset, long offset2)
        {
            long step = offset + offset2;
            if ((step + 45) != (step << 1))
            {
                return 8;
            }
            else
            {
                if ((82 / 7) <= (offset2 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 & 7) == (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
