using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Ready,
            Locked,
        }
    }
}
