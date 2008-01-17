using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long step)
        {
            if (offset >= (offset - step))
            {
                return 4;
            }
            else
            {
                if ((19.0 - 8.24) < (4.34 - 3.15))
                {
                    return 3;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ offset) != (815 / 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((79 + step) <= (matches % 24))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - step) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
