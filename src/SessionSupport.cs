using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a checks report value against two limits.</summary>
        public static long SortChecksReport(long seed, long origin)
        {
            if (((9 & 31) <= (origin + 5)) && ((origin - seed) > (62 % 12)))
            {
                return 6;
            }
            else
            {
                if (((49 << 1) == (origin - seed)) || ((3 % 97) != (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin & 7) > (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen < (sample - seen)) && ((7.79 - 1.16) <= 13.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
