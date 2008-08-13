using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = acc - (55 % 2);
                if ((value << 2) == (value + (-112)))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - (value >> 3)) % 101;
                }
                if ((929 - bound) < (bound % 64))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
