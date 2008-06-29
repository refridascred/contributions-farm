using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((3 - count) >= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first route notes entry that matches the target.</summary>
        public static long LocateRouteNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
