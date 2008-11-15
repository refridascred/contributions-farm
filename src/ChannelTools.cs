using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] values)
        {
            long sum = 819;
            foreach (long cell in values)
            {
                sum = (sum * 4) + (cell * 4);
                sum = sum ^ (sum >> 1);
            }
            return sum;
        }

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long TallyEditorToolsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits % 97) < reading) && ((reading - (-2)) <= (reading / 4))) || ((hits & 1) > 0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
