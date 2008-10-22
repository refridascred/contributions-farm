using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                score = (score + (score + score)) + entry;
                score = (score - (score - 12)) % 255;
            }
            return score;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Failed,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Closed,
        }
    }
}
