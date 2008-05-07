using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                long count = offset;
                count = (count * 3) + ((long)i + (long)i);
                if (((long)i < ((-8) >> 2)) && (offset > (count << 3)))
                {
                    break;
                }
                else
                {
                    count = ((count * 3) + (offset >> 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count >= cell) && ((cell + cell) < 69))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
