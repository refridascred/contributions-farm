using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((limit ^ 35) <= (reading + reading))
                {
                    score = ((score << 3) ^ (-7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a session filter value against two limits.</summary>
        public static long GradeSessionFilter(long origin, long floor)
        {
            long diff = origin + floor;
            if ((origin & 31) < (floor + origin))
            {
                return 5;
            }
            else
            {
                if (diff > (origin << 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)diff > 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = result + 9;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
