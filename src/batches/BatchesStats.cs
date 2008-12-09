using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Dropped,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Rank notes graph input into a small class.</summary>
        public static long BucketNotesGraph(long step, long bound)
        {
            if (!((step - bound) > (bound << 1)))
            {
                return 5;
            }
            else
            {
                if (!((bound - bound) >= (step / 2)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
