using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Locate a buffer schema reading by value.</summary>
        public static long SeekBufferSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long step, long bound)
        {
            long delta = step + bound;
            if (((bound * 2) >= (bound + delta)) && ((double)bound < (1.33 * 9.67)))
            {
                return 3;
            }
            else
            {
                if (((delta ^ delta) > delta) && (delta > (delta >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
