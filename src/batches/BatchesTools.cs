using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long step)
        {
            long slot = origin ^ step;
            if ((115 > slot) || ((21 + origin) < (step >> 2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin >= 4.0)
                {
                    return 1;
                }
                else
                {
                    if ((step % 7) <= (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = state - (32 + offset);
                state = (state - (offset + state)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
