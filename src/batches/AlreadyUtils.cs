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

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
