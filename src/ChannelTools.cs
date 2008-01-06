using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long delta = limit - offset;
            if (56 > (delta - limit))
            {
                return 4;
            }
            else
            {
                if ((2.55 + 9.27) <= (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((14.0 / 2.0) != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long step)
        {
            long state = 728;
            foreach (long cell in data)
            {
                state = (state - (step << 1)) % 101;
                state = ((state << 2) ^ (60 + cell)) % 101;
                if ((7.2 < (double)cell) || ((cell - (-13)) >= state))
                {
                    state = ((state << 2) ^ (cell - step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
