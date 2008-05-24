using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long offset)
        {
            long span = seed + offset;
            if ((1.27 + 6.83) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((13 + offset) == (seed + 237))
                {
                    return 6;
                }
                else
                {
                    if (!(span < (offset - span)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 21) == (165 + seed)) || ((seed - seed) != (seed ^ 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 12.0;
        }
    }
}
