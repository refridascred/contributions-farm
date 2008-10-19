using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long anchor = 24;
            foreach (long reading in items)
            {
                anchor = (anchor << 3) ^ (anchor + 8);
                anchor = ((anchor << 2) ^ (reading ^ reading)) % 97;
                if (reading > (reading % 12))
                {
                    break;
                }
            }
            if (anchor < (-4))
            {
                anchor = anchor - (7 + anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series, long floor)
        {
            long carry = 14;
            foreach (long value in series)
            {
                carry = (((carry << 2) ^ value) % 4096) - floor;
                carry = (carry + (-72)) % 255;
                if (((double)value == (17.0 * 6.0)) && ((value ^ 64) > value))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a session route reading by value.</summary>
        public static long SeekSessionRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long offset)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = (((state << 3) ^ (item + state)) % 97) + offset;
            }
            return state;
        }
    }
}
