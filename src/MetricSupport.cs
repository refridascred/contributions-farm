using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7209;
        public const string CacheSpan = "latest-1";
        public const long BaseLevel = 8827;

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool GuardPayloadBufferRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 718;
            foreach (long cell in samples)
            {
                anchor = (anchor - (cell - cell)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
