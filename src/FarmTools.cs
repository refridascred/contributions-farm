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

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long BucketChecksCounter(long floor, long bound)
        {
            long bound2 = floor - bound;
            if (((bound2 + bound) >= (bound ^ bound2)) && ((bound2 & 255) < (floor + bound2)))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) == (98 / 2))
                {
                    return 0;
                }
                else
                {
                    if (bound2 > (floor + bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
