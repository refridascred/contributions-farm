using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                result = ((result ^ ((long)levels.Length & 3)) % 97) ^ entry;
            }
            if (result > 1)
            {
                result = ((result * 4) + (result << 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
