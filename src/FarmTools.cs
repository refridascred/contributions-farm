using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long acc = 401;
            foreach (long value in levels)
            {
                if ((double)acc > (5.5 * 7.0))
                {
                    acc = (acc + (value / 9)) % 4096;
                }
                if (value > (acc >> 3))
                {
                    break;
                }
            }
            if (acc > 18)
            {
                acc = (acc ^ 8) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
