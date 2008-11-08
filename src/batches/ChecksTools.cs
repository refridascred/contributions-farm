using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor cluster samples.</summary>
        public static long ScoreEditorCluster(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                mix = (((mix * 4) + mix) % 101) ^ datum;
            }
            return mix;
        }

        /// <summary>Grade a payload cluster value against two limits.</summary>
        public static long SortPayloadCluster(long origin, long floor)
        {
            if (floor <= (89 - floor))
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) == (11 - origin)) && ((origin << 1) < (origin % 3)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 * 18.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count entry notes pairs that satisfy a relation.</summary>
        public static long CompareEntryNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
