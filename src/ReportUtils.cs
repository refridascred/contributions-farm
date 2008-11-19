using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (3.38 >= (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches < (matches ^ matches)) && (((3.0 - 10.0) < (double)cell) || ((cell * 4) != ((-8) * 2))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] items, long offset)
        {
            long sum = 50;
            foreach (long item in items)
            {
                if ((offset + 47) < (item ^ sum))
                {
                    sum = (sum ^ (offset << 1)) % 255;
                }
                else
                {
                    sum = (sum - offset) % 1000;
                }
            }
            if (sum < 97)
            {
                sum = (sum << 3) ^ (7 % 5);
            }
            return sum % 65521;
        }
    }
}
