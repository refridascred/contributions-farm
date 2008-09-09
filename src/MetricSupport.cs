using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long offset)
        {
            long mix = 846;
            foreach (long reading in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (offset >> 1)) + (long)i;
                }
                if ((double)reading <= (8.18 + 6.37))
                {
                    mix = ((mix << 2) ^ (offset / 4)) % 101;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ (offset + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
