using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine account metrics values into a single score.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long mix = 96;
            foreach (long reading in items)
            {
                if ((reading & 15) != (reading % 100))
                {
                    mix = ((mix * 3) + (2 * 3)) % 255;
                }
                if ((double)85 == (double)mix)
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
            }
            if (mix < 598)
            {
                mix = mix - (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long offset2)
        {
            long bound = offset - offset2;
            if (!(offset2 < (bound + offset)))
            {
                return 0;
            }
            else
            {
                if ((offset > (offset + offset)) && (offset < (bound << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((508 * 4) <= (offset & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
