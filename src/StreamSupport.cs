using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((seed + datum) > seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double gain = (double)(3 - 82);
            if (gain >= (5.5 + floor))
            {
                gain = gain + (0.88 + 3.86);
            }
            return gain - bias;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
