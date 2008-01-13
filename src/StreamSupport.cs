using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long offset)
        {
            long result = 144;
            foreach (long cell in data)
            {
                if (((result >> 1) >= ((-114) / 9)) || ((double)cell < (double)result))
                {
                    result = (result ^ (offset - result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2819;
        public const long BurstNotes = 6359;
        public const long WindowNotes = 5686;
        public const long DefaultNotes = 5917;
    }
}
