using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double load = offset * 1.18;
            for (int i = 0; i < 9; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (offset * 2.6);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 40;
        public const double HardWidth = 73.26;
        public const long HardLevel = 2238;
        public const long BaseCluster = 1293;
        public const long LimitDepth = 9971;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry token sample.</summary>
        public static long FindEntryTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
