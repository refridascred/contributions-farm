using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long MeasureContributiFormatHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (matches + bound))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches < (5.56 * 1.6))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph record pair into a bucket.</summary>
        public static long RankGraphRecord(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((8.0 + 4.3) == (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!(5.2 >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (double)50)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.3 + 3.3) > (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
