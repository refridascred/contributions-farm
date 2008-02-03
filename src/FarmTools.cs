using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry < (6.0 * 8.11)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long step)
        {
            if ((step >> 4) != (limit & 255))
            {
                return 3;
            }
            else
            {
                if (((double)step != (1.76 * 9.5)) || ((17.0 + 6.7) < (1.43 * 15.0)))
                {
                    return 6;
                }
                else
                {
                    if ((5.1 - 5.5) < (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
