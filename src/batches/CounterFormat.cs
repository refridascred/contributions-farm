using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item << 3) > (count + count))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((double)limit == (8.75 + 7.8))
            {
                return 4;
            }
            else
            {
                if (!((step - limit) <= (9 + step)))
                {
                    return 6;
                }
                else
                {
                    if ((-9) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 / 7) == (step & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
