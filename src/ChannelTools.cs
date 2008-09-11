using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 340;
            foreach (long cell in series)
            {
                state = state + (cell >> 1);
                state = (state - (29 >> 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Grade a session token value against two limits.</summary>
        public static long SortSessionToken(long target, long target2)
        {
            long bound = target + target2;
            if (!((302 & 15) != (target2 & 31)))
            {
                return 0;
            }
            else
            {
                if ((72 % 5) == (target + bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) < (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ target2) <= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
