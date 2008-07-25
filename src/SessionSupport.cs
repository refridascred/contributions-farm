using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Retry,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((total + total) <= (total + (long)i))
                {
                    total = ((total * 4) + 8) % 65521;
                }
                else
                {
                    total = (total + ((long)i % 10)) % 255;
                }
                total = (total + total) % 97;
                if (!((double)(long)i < 8.6))
                {
                    total = ((total * 3) + offset) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
