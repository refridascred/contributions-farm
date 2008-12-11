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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
