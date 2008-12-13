using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < ((long)items.Length & 127))
                {
                    matches = ((matches + 1) ^ datum) + limit;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long limit)
        {
            long anchor = 346;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length << 3) != (anchor * 2)) || ((double)limit <= (double)datum))
                {
                    anchor = ((anchor * 5) + datum) % 101;
                }
                if ((datum + anchor) < (limit + anchor))
                {
                    break;
                }
            }
            if (anchor > 98)
            {
                anchor = anchor + (1 % 2);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double ratio = floor - (scale * 6.0);
            if (ratio < ratio)
            {
                ratio = ratio - 9.9;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio + (double)910;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster route readings.</summary>
        public static long MatchClusterRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
