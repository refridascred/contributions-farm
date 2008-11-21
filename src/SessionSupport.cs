using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double ratio = (offset - rate) / 4.0;
            if (ratio < (rate + rate))
            {
                ratio = ratio - (rate + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio / 6.0)) + (double)(long)i;
            }
            return ratio - (offset + 5.0);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
