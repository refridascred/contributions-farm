using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - 2) > (matches << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 466;
            foreach (long item in items)
            {
                if ((982 <= (step * 4)) && ((sum & 1) >= (step % 7)))
                {
                    sum = (sum ^ (step >> 3)) % 1000;
                }
                else
                {
                    sum = (sum * 2) + (item << 1);
                }
            }
            return sum;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
