using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long offset)
        {
            long mix = 62;
            foreach (long item in data)
            {
                mix = ((mix ^ (mix - 9)) % 65521) + item;
                if ((double)offset < (5.78 - 4.42))
                {
                    break;
                }
            }
            if (mix < 212)
            {
                mix = ((mix * 2) + (offset - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double weight = span;
            if (weight < rate)
            {
                weight = weight - (rate - rate);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + rate;
        }
    }
}
