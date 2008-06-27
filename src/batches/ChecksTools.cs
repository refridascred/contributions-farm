using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!!(13.0 >= (double)total))
                {
                    total = (total + (total << 3)) % 1000;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) >= 67)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
