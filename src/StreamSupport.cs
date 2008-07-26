using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Rank metric command input into a small class.</summary>
        public static long ClassifyMetricCommand(long limit, long step)
        {
            long slot = limit + step;
            if ((slot / 3) < limit)
            {
                return 6;
            }
            else
            {
                if ((17.0 - 6.14) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((4.1 / 6.0) != (double)step) && ((slot - limit) >= slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)324 <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultInterval = 5805;
        public const long MaxBuffer = 6087;
        public const long SoftFactor = 6024;
    }
}
