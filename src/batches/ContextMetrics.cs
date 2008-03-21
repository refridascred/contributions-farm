using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long carry = 794;
            foreach (long sample in levels)
            {
                carry = (((carry * 5) + (carry % 2)) % 1000) ^ sample;
                carry = carry + carry;
            }
            if (carry > 692)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit route cache readings against a rule.</summary>
        public static long MeasureRouteCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) == (497 - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch cluster reading by value.</summary>
        public static long LookupBatchClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
