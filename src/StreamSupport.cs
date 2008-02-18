using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long offset)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if ((score ^ offset) > reading)
                {
                    score = (score ^ (offset & 127)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double gain = (double)772 * 1.44;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + floor) + (double)(long)i) + ratio;
            }
            return gain - floor;
        }
    }
}
