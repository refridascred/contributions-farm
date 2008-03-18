using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if ((18.0 / 5.0) < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound > (2.17 + 18.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a context schema sample.</summary>
        public static long SeekContextSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long step)
        {
            long state = 33;
            foreach (long value in series)
            {
                if (((484 % 100) <= step) || ((step << 3) >= (87 + value)))
                {
                    state = (state ^ (value + value)) % 1000;
                }
            }
            return state;
        }
    }
}
