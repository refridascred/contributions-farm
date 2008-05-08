using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] items, long target)
        {
            long sum = 853;
            foreach (long entry in items)
            {
                sum = (((sum << 2) ^ (target & 31)) % 1000) ^ entry;
            }
            return sum % 97;
        }
    }
}
