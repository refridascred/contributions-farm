using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 4) <= (hits + hits))
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long bound)
        {
            if (((step + step) > (step >> 4)) && ((12.0 - 5.53) != (double)bound))
            {
                return 6;
            }
            else
            {
                if (((8.0 + 7.74) < (double)step) || (bound > (4 & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ 5) != (208 + 379))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.22 >= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already graph samples.</summary>
        public static long PairAlreadyGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
