using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long SortBufferEditor(long origin, long origin2)
        {
            if ((origin + origin) > (origin * 2))
            {
                return 2;
            }
            else
            {
                if (!((origin2 - origin) > origin2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Queued,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long mark = -48;
            foreach (long item in levels)
            {
                mark = (mark ^ item) % 97;
                if ((1 + mark) >= item)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
