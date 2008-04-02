using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next buffer context value.</summary>
        public static double SmoothBufferContext(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias2)
            {
                gain = (gain - gain) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (gain / 6.0)) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mark = -5;
            foreach (long sample in levels)
            {
                if ((sample > (sample & 63)) && (sample > 46))
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 97;
                }
                mark = ((mark << 3) ^ (mark + sample)) % 4096;
                mark = (mark * 4) + sample;
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
