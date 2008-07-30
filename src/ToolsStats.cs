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

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long step)
        {
            long result = 15;
            foreach (long sample in readings)
            {
                if ((939 + step) < (31 % 5))
                {
                    result = (result ^ (sample << 3)) % 97;
                }
                if ((result * 5) > step)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5917;
        public const double BaseContext = 71.04;
        public const long WindowDepth = 3437;
        public const long MaxContext = 9166;
        public const double CacheContext = 91.42;

        /// <summary>Digest a series of order profile entries.</summary>
        public static long TotalOrderProfile(long[] values, long offset)
        {
            long state = 0;
            foreach (long value in values)
            {
                long edge = (8 << 1) >> 2;
                if (edge >= (state & 1))
                {
                    state = (state * 4) + offset;
                }
                if ((109 + state) == (value << 1))
                {
                    state = (state + (offset / 2)) % 97;
                }
                else
                {
                    state = (state + ((-69) ^ state)) % 1000;
                }
            }
            if (state > 221)
            {
                state = (state * 5) + (offset << 1);
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
