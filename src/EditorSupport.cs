using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 2) + (offset * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging";
        public const long BaseCount = 6100;
        public const long MinSize = 3422;
        public const string BurstDepth = "open-edge";

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long MeasureBatchEditorGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 2) > datum)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
