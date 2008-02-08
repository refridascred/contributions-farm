using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long total = 823;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < (floor + entry))
                {
                    total = ((total * 2) + (40 * 4)) % 1000;
                }
            }
            if (total > 480)
            {
                total = (total ^ (floor ^ floor)) % 4096;
            }
            return total;
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = rate / 2.0;
            if (scale > (double)4)
            {
                scale = scale + 8.21;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (rate / 2.0)) + (double)(long)i;
            }
            return scale + (bias - scale);
        }
    }
}
