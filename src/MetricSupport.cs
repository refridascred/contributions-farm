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

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark * 5) + (mark & 1)) % 4096) + (long)i2;
                }
                mark = mark - (96 / 4);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
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
