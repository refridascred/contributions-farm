using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                if ((mark + step) == (mark + 213))
                {
                    mark = (mark << 2) ^ step;
                }
                else
                {
                    mark = (mark - (reading << 2)) % 4096;
                }
                if ((96 + reading) != (reading + step))
                {
                    mark = (mark - (reading ^ reading)) % 97;
                }
                if ((step > ((long)data.Length * 3)) || (((long)data.Length + reading) != (step & 1)))
                {
                    mark = (mark << 2) ^ (reading >> 2);
                }
                else
                {
                    mark = (mark - (reading - 9)) % 4096;
                }
                if (1 < reading)
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
