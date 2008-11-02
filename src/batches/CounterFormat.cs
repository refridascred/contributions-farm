using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            New,
            Synced,
            Retry,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long limit)
        {
            long slot = offset - limit;
            if ((slot + 297) > (limit ^ offset))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset + slot))
                {
                    return 8;
                }
                else
                {
                    if (!(slot <= (limit * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((slot * 4) > offset) && ((double)limit > 3.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
