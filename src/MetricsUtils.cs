using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long state = 6;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry / 7)) % 101;
            }
            return state;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Active,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long result = 195;
            foreach (long reading in levels)
            {
                result = (result ^ (reading >> 5)) % 1000;
                if ((24 + 381) != (step % 100))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            New,
            Synced,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Active,
            Queued,
        }
    }
}
