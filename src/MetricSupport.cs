using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a queue command sample.</summary>
        public static long LookupQueueCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long step)
        {
            if ((offset < (step / 3)) || ((double)step < (6.8 / 2.0)))
            {
                return 7;
            }
            else
            {
                if ((763 & 7) != (step % 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset != (6.0 * 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
