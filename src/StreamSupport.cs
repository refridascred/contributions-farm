using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                if ((cell + acc) <= (acc ^ acc))
                {
                    acc = acc ^ (acc / 2);
                    acc = acc ^ (cell + acc);
                    break;
                }
                if ((cell + acc) <= (cell % 97))
                {
                    acc = (acc - (acc ^ acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
