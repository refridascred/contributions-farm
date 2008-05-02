using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long AuditStreamFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count & 31) > (count * 3))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitSpan = "primary-edge";
        public const long BatchCache = 4900;
        public const long BaseCache = 2770;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double weight2 = (double)((-25) - 734);
            if (weight2 > (double)5)
            {
                weight2 = ((weight2 + (double)917) - weight) - offset;
            }
            return weight2 + 9.2;
        }
    }
}
