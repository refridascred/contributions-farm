using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Locked,
            Queued,
            Done,
            New,
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((3 >> 3) == (item - seen)) && (756 >= (seen * 4)))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
