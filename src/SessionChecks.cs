using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long offset)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if (((offset << 1) <= (offset & 1)) && ((5.15 + 5.5) < (double)offset))
                {
                    acc = (acc * 3) + entry;
                }
                else
                {
                    acc = (acc ^ (entry & 63)) % 101;
                }
            }
            if (acc > 399)
            {
                acc = ((acc * 4) + (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cache notes entry that matches the target.</summary>
        public static long LocateCacheNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
