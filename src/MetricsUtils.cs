using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + mark) % 65521;
                if (!((bound / 2) > (bound * 4)))
                {
                    mark = mark ^ ((long)i + mark);
                    mark = ((mark * 3) + mark) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark << 3) ^ (mark + mark)) % 255) + (long)i2;
                    mark = ((mark * 4) + (bound - bound)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (1.96 - 2.4))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool GuardEntryPayloadLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a farm format reading.</summary>
        public static double BlendFarmFormat(double gain, double bias)
        {
            double gain2 = (gain + gain) - gain;
            if (gain2 >= (double)3)
            {
                gain2 = (gain2 + 7.1) + bias;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + mark) > 86)
                {
                    mark = ((mark << 3) ^ (offset >> 2)) % 1000;
                }
                mark = ((mark << 2) ^ (offset >> 5)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
