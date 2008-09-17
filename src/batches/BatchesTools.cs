using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of record buffer entries.</summary>
        public static long CombineRecordBuffer(long[] series)
        {
            long mix = 33;
            foreach (long entry in series)
            {
                if (((mix * 2) >= mix) && (entry <= (mix << 3)))
                {
                    mix = ((mix << 3) ^ (mix * 5)) % 65521;
                }
            }
            if (mix > 51)
            {
                mix = (mix ^ (mix >> 1)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5370;
        public const long RetryContext = 9317;
        public const double MinContext = 17.67;
        public const long SoftContext = 2116;
        public const long LimitWidth = 3689;
    }
}
