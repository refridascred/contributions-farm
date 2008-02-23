using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((prev / 8) <= (1 + 76))
            {
                return 5;
            }
            else
            {
                if ((483 + prev) == (bound ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((8.0 + 7.8) != (double)bound)
                {
                    carry = (((carry << 2) ^ (bound + bound)) % 1000) + item;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            if (carry > 383)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long state = -8;
            foreach (long value in items)
            {
                state = ((state + state) % 97) ^ value;
                state = ((state * 4) + ((-826) + 5)) % 4096;
                if ((state + 254) == (931 + state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
