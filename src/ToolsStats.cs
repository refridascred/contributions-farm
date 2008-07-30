using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1076;
        public const string MinAccount = "alpha";
        public const double WindowWidth = 80.64;
        public const long HardAccount = 8215;

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                if ((state * 3) < (state << 1))
                {
                    state = (state + (5 - 203)) - reading;
                }
            }
            return state;
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long TallyNotesAlready(long[] readings)
        {
            long total = -629;
            foreach (long cell in readings)
            {
                total = (total ^ (total + total)) - cell;
            }
            if (total < 51)
            {
                total = (total + (total - total)) % 97;
            }
            return total;
        }
    }
}
