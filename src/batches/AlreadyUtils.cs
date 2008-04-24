using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                mix = (mix - (471 - datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long step)
        {
            if (step >= (seed >> 5))
            {
                return 4;
            }
            else
            {
                if (step <= (step + step))
                {
                    return 8;
                }
                else
                {
                    if ((9 << 2) == (step + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((492 ^ seed) > (step % 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 16) != (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
