using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Dropped,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long bound)
        {
            long result = 723;
            foreach (long cell in items)
            {
                if ((result + result) <= (cell ^ cell))
                {
                    result = ((result * 3) + (86 >> 2)) % 97;
                }
            }
            if (result < 803)
            {
                result = (result - bound) % 4096;
            }
            return result;
        }
    }
}
