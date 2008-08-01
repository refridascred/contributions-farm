using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool CheckChecksLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long offset2)
        {
            if (!((offset / 7) >= (offset2 * 4)))
            {
                return 6;
            }
            else
            {
                if (((1 / 4) == (offset ^ offset)) && (((-63) + offset) < (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - 54) >= (offset2 ^ offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((hits / 8) != (hits >> 4)) || ((double)hits <= (double)reading)) && ((hits ^ reading) > (reading ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
