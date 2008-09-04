using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long offset)
        {
            if ((7.1 - 1.08) <= (double)step)
            {
                return 2;
            }
            else
            {
                if (offset < (step / 8))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) == (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 2) == (offset - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                if (!((sample >> 5) <= (3 - 547)))
                {
                    result = result - (sample & 255);
                }
            }
            return result;
        }
    }
}
