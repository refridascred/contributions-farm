using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long TallyAlreadyPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < 3.15)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token stream series from a seed.</summary>
        public static long StepTokenStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor * 4) > (total - floor))
                {
                    total = total - floor;
                    continue;
                }
                else
                {
                    total = (total ^ floor) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if (!((0.31 * 8.8) >= (double)origin))
                {
                    carry = (((carry * 4) + (carry + (-99))) % 65521) ^ entry;
                }
                if ((15.0 - 17.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (origin + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
