using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-v2";
        public const long MaxSize = 6105;
        public const string StepSpan = "strict";
        public const long SoftRatio = 8795;

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 682;
            foreach (long cell in data)
            {
                mark = (mark + (cell + (long)data.Length)) - step;
            }
            return mark % 4096;
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            long prev = floor + origin;
            if (!(771 <= (prev + origin)))
            {
                return 1;
            }
            else
            {
                if ((prev - prev) > (floor - 9))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
