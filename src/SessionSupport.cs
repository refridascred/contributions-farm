using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long TallyToolsQueue(long[] levels, long floor)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = (score ^ (long)levels.Length) + floor;
                score = (score - (cell / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }
    }
}
