using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
