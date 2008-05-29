using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= gain)
            {
                gain2 = gain2 - (double)122;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + (gain + 0.7);
        }

        /// <summary>Fold a list of report already readings.</summary>
        public static long WeighReportAlready(long[] levels)
        {
            long mark = 508;
            foreach (long datum in levels)
            {
                if (mark <= (1 + datum))
                {
                    mark = ((mark << 2) ^ (mark + datum)) % 101;
                }
            }
            if (mark > 7)
            {
                mark = mark + (13 / 4);
            }
            return mark;
        }
    }
}
