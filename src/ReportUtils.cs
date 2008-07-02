using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long score = 77;
            foreach (long sample in data)
            {
                score = (score - score) - sample;
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double load = span * 0.83;
            if (load <= gain)
            {
                load = load - (double)5;
            }
            return load + (load - gain);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = result - result;
                result = (result - (result / 2)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Closed,
            Locked,
        }
    }
}
