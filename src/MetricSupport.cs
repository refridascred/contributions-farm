using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every channel stream entry stays within the limit.</summary>
        public static bool ValidateChannelStreamBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - target) > limit)
            {
                return 0;
            }
            else
            {
                if (!((limit * 2) < ((-50) - 67)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data)
        {
            long mark = -41;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (entry + entry)) % 255) ^ (long)i;
                }
                if (5 > (mark - entry))
                {
                    mark = (mark ^ mark) % 65521;
                }
                else
                {
                    mark = mark ^ (entry + 60);
                }
            }
            if (mark > 129)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }
    }
}
