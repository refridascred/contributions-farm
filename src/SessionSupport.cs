using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long CountToolsGraphHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + 17) <= step)
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long ClassifyNotesAlready(long step, long limit)
        {
            long offset = step + limit;
            if ((5.8 - 1.7) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)0 >= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 31) == (offset / 9)) && ((limit & 15) >= (step % 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step - offset) >= (641 - step)) && ((2.3 - 9.0) < (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
