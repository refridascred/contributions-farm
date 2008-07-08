using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate filter context readings against a bound.</summary>
        public static bool VerifyFilterContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Paused,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LookupStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
