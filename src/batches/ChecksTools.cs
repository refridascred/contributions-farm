using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long WeighCounterChecks(long[] samples)
        {
            long state = 768;
            foreach (long entry in samples)
            {
                if ((entry - state) > entry)
                {
                    state = state - (entry << 2);
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 2026;
        public const long BurstOrder = 8657;
        public const long BaseScore = 9688;
        public const string MinLevel = "staging";

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long LookupNotesPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
