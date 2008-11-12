using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (limit - limit);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches ^ cell) <= (73 - cell))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry notes pairs that satisfy a relation.</summary>
        public static long OverlapEntryNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
