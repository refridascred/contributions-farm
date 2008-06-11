using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long origin)
        {
            long span = step ^ origin;
            if (step > (step + origin))
            {
                return 4;
            }
            else
            {
                if ((12.0 / 4.0) > (double)span)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
