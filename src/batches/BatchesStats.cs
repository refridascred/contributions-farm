using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i >> 3) > carry) || ((14.0 + 8.3) <= (double)offset))
                {
                    carry = carry + (offset ^ offset);
                    carry = carry - offset;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 9794;
        public const string WindowRatio = "cached-v2";
        public const long DefaultInterval = 7805;
        public const long LimitSize = 3878;
    }
}
