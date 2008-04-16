using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window channel input into a small class.</summary>
        public static long GradeWindowChannel(long target, long floor)
        {
            if (floor > (floor * 2))
            {
                return 4;
            }
            else
            {
                if ((target << 2) != (floor + 227))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 16) != (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= (floor << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7379;
        public const double LimitReport = 2.58;
        public const long MinReport = 7522;
        public const long WindowReport = 1539;
    }
}
