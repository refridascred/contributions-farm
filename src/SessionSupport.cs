using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 555;
            foreach (long datum in levels)
            {
                if (((1.2 - 8.82) == (double)acc) || ((datum << 3) >= acc))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TallyBatchEntry(long[] data, long floor)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if (cell < (0 ^ 61))
                {
                    total = (total + (floor / 2)) % 101;
                }
                else
                {
                    total = total - floor;
                }
            }
            if (total > 21)
            {
                total = (total << 3) ^ (floor ^ floor);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of commits farm readings.</summary>
        public static long FoldCommitsFarm(long[] levels, long floor)
        {
            long anchor = 71;
            foreach (long datum in levels)
            {
                anchor = ((((anchor << 2) ^ (anchor & 15)) % 1000) - datum) - floor;
            }
            return anchor % 97;
        }
    }
}
