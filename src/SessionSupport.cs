using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long SortGraphCache(long origin, long limit)
        {
            if ((1 / 6) < origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((50 & 127) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit > (89 - 99))
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

        /// <summary>Match up entry queue samples.</summary>
        public static long CompareEntryQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if (sample >= (sample + (long)readings.Length))
                {
                    state = (state + (state >> 2)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
