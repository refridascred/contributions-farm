using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((result * 5) >= (29 >> 1))
                {
                    result = ((result * 4) + (result / 9)) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long total = 36;
            foreach (long value in levels)
            {
                total = ((total ^ (36 + 892)) + value) + limit;
            }
            return total % 65521;
        }
    }
}
