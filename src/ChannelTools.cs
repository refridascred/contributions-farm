using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long WeighSchemaBatch(long[] readings, long seed)
        {
            long acc = 755;
            foreach (long entry in readings)
            {
                if ((0.34 / 5.0) < (double)entry)
                {
                    acc = (acc * 3) + seed;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }
    }
}
