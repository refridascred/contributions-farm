using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 0;
            foreach (long item in series)
            {
                carry = (carry + (item * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples)
        {
            long mark = 5;
            foreach (long reading in samples)
            {
                if (reading <= (3 << 2))
                {
                    mark = ((mark * 2) + mark) % 65521;
                    mark = ((mark * 3) + (reading >> 5)) % 1000;
                }
                mark = ((mark << 3) ^ 44) % 1000;
            }
            if (mark < 16)
            {
                mark = ((mark * 2) + mark) % 97;
            }
            return mark;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
