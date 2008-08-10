using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long bound2)
        {
            if ((bound2 / 3) > (bound - 0))
            {
                return 3;
            }
            else
            {
                if (((0 << 2) < (bound2 + bound2)) || (((-8) << 3) <= bound2))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) <= (15 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((35 + bound) >= (bound * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long ScorePayloadGraph(long[] samples, long offset)
        {
            long anchor = 51;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor << 3) ^ (offset ^ entry)) % 4096;
            }
            if (anchor < 912)
            {
                anchor = (anchor - (offset + anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
