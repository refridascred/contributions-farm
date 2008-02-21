using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool ValidatePayloadBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
