using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total ^ 1)) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long FindMetricsWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((0 + datum) >= matches))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long offset)
        {
            long carry = 31;
            foreach (long entry in samples)
            {
                carry = (carry ^ (long)samples.Length) ^ entry;
                carry = ((carry << 3) ^ carry) % 255;
            }
            if (carry < 92)
            {
                carry = ((carry * 4) + (offset % 64)) % 4096;
            }
            return carry % 65521;
        }
    }
}
