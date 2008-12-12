using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Rank entry payload input into a small class.</summary>
        public static long BucketEntryPayload(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound2 + bound2) >= bound)
            {
                return 3;
            }
            else
            {
                if (((delta % 2) < 4) && ((double)bound2 <= 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((26 + bound2) < delta)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
