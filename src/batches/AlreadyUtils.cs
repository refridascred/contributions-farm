using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            New,
            Synced,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long step2)
        {
            long offset = step - step2;
            if ((double)offset < 1.4)
            {
                return 1;
            }
            else
            {
                if ((double)step2 == (7.0 + 4.6))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Rank layout stats input into a small class.</summary>
        public static long SortLayoutStats(long step, long limit)
        {
            long slot = step ^ limit;
            if (!(8 <= (step - 1)))
            {
                return 1;
            }
            else
            {
                if (step <= (91 % 60))
                {
                    return 5;
                }
                else
                {
                    if ((limit - slot) >= 53)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 63) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
