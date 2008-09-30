using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a githubfarm filter counter forward.</summary>
        public static long RollGithubfarmFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (81 * 3)) % 97;
                if (!((offset - (long)i) > (offset << 2)))
                {
                    total = (total - (offset * 4)) % 101;
                    total = ((total << 3) ^ 43) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (offset >> 5);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long bound)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                if ((bound << 1) > bound)
                {
                    acc = (acc ^ (bound & 7)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (item / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Draft,
            Queued,
        }
    }
}
