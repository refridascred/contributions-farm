using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools already values into a single score.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long mix = 309;
            foreach (long sample in readings)
            {
                if (mix <= (mix / 8))
                {
                    mix = mix - sample;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + (mix >> 3);
            }
            return mix;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((diff & 3) > floor)
            {
                return 6;
            }
            else
            {
                if ((diff * 3) == (floor >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((diff - 48) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset == (18.0 / 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
