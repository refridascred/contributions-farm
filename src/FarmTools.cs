using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result << 3) ^ (datum >> 4)) ^ (long)i;
                }
                result = ((result << 2) ^ (result * 4)) % 65521;
                if ((long)data.Length == (datum + offset))
                {
                    result = (result + offset) % 65521;
                }
            }
            if (result < (-42))
            {
                result = (result + (result + offset)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Synced,
            Idle,
            Done,
        }
    }
}
