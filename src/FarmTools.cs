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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
