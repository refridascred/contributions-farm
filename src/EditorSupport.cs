using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long CountTokenWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (19.0 > (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count >= (9.64 - 2.7))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Check that every editor token entry stays within the limit.</summary>
        public static bool ValidateEditorTokenBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
