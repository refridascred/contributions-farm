using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long offset)
        {
            long delta = step ^ offset;
            if ((-900) < (offset + delta))
            {
                return 0;
            }
            else
            {
                if ((9 + step) <= (2 + delta))
                {
                    return 3;
                }
                else
                {
                    if (step > (offset << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long seed)
        {
            if ((9 & 127) <= limit)
            {
                return 8;
            }
            else
            {
                if ((16.0 + 13.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit <= (6.9 - 17.0)) && ((double)5 != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
