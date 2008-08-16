using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Queued,
            Ready,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if ((result + 4) >= (1 - cell))
                {
                    result = result + (cell * 4);
                }
                else
                {
                    result = result + 38;
                }
            }
            if (result < 50)
            {
                result = result ^ (result / 4);
            }
            return result;
        }
    }
}
