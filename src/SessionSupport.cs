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

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series, long seed)
        {
            long acc = -772;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ (seed ^ (long)i)) + item;
                }
                if (((acc - acc) <= ((-72) % 24)) && (42 <= seed))
                {
                    acc = acc + (acc >> 3);
                }
            }
            if (acc < 59)
            {
                acc = acc - ((-99) + acc);
            }
            return acc;
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
