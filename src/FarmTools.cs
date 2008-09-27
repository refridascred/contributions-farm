using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + 522) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally - cell) > (tally & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long ClassifyContextRoute(long origin, long offset)
        {
            if (!((3 - offset) > offset))
            {
                return 7;
            }
            else
            {
                if (offset >= (925 << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset <= (18.0 - 18.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3 / 9) < origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
