using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long bound, long step)
        {
            if ((double)step < (4.9 - 6.0))
            {
                return 0;
            }
            else
            {
                if (!(step < (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((8.24 - 6.3) != (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + bound) >= (62 ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
