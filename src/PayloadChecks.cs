using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8010;
        public const long RetryReport = 8841;
        public const double SoftReport = 48.35;
        public const long WindowReport = 7962;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultWidth = 86.61;
        public const long DefaultMetric = 6476;
        public const long SoftMetric = 4422;
        public const double RetryInterval = 19.76;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long RankBufferCommand(long origin, long target)
        {
            if ((origin < (origin * 4)) || ((target ^ 49) >= (target % 2)))
            {
                return 4;
            }
            else
            {
                if ((origin & 1) > target)
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) < (target ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + target) >= (target ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
