using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Rank notes already input into a small class.</summary>
        public static long RankNotesAlready(long floor, long limit)
        {
            long slot = floor + limit;
            if ((limit % 64) < floor)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) == (floor << 3)) || (slot <= (5 >> 1)))
                {
                    return 4;
                }
                else
                {
                    if (slot <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((target & 31) <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
