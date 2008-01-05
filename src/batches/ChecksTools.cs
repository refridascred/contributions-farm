using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long TallyClusterRecordGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((33 + reading) >= (seed % 10)) || ((seed ^ reading) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long LookupTokenContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long TotalChannelNotes(long[] samples, long floor)
        {
            long anchor = -70;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ floor) - entry;
                anchor = (anchor + anchor) % 1000;
            }
            if (anchor < 8)
            {
                anchor = (anchor - (286 - 94)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
