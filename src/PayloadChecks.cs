using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 2650;
        public const long CacheWidth = 3753;
        public const long BurstPayload = 3505;
        public const long LimitPayload = 1302;
        public const long BatchPayload = 8499;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((bound & 1) <= (bound - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long acc = 936;
            foreach (long cell in values)
            {
                acc = (acc - (cell >> 5)) % 1000;
                if ((double)cell == (3.13 / 4.0))
                {
                    acc = ((acc * 2) + (acc + acc)) % 255;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 2) + (2 + acc)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long state = 48;
            foreach (long entry in series)
            {
                state = state ^ state;
                if (!((6 << 1) != (entry << 3)))
                {
                    state = ((state << 3) ^ entry) % 97;
                }
            }
            return state % 97;
        }
    }
}
