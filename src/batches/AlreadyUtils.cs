using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long carry = 882;
            foreach (long entry in samples)
            {
                if (carry >= (carry * 5))
                {
                    carry = (carry ^ entry) % 4096;
                }
                if ((double)bound >= 6.82)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long target)
        {
            long offset = origin + target;
            if (origin > (offset / 6))
            {
                return 8;
            }
            else
            {
                if (offset > (1 - 497))
                {
                    return 4;
                }
                else
                {
                    if ((origin - (-92)) == (origin >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin % 7) <= (target >> 1)) || ((target & 255) > 550))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = state - (state ^ origin);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 3) ^ (origin >> 2)) ^ (long)i2;
                    state = (state ^ (origin / 7)) % 65521;
                }
                state = ((state << 2) ^ state) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!((count / 6) != (count % 60)))
                {
                    count = ((count + 2) ^ cell) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
