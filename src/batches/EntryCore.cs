using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long step)
        {
            long result = 442;
            foreach (long cell in items)
            {
                if ((cell >> 2) > (39 * 2))
                {
                    result = ((result << 2) ^ (result ^ 628)) - step;
                }
            }
            if (result > 108)
            {
                result = (result ^ (95 - result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long offset)
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches - matches) <= (reading * 3)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Draft,
            Failed,
            Pending,
            Synced,
        }
    }
}
