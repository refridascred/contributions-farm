using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "legacy";
        public const long CacheTimeout = 5615;
        public const long SoftSupport = 8210;

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long DigestFormatMetrics(long[] readings)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                state = ((state << 3) ^ state) % 1000;
                if ((57 - 83) < (state % 16))
                {
                    state = ((state * 3) + (entry & 7)) % 255;
                }
            }
            if (state > 40)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 2) != (603 - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the context cluster entries that pass the check.</summary>
        public static long TallyContextClusterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 2.69)
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value >> 5) <= tally) && ((double)2 < (double)tally)) && ((double)tally != (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
