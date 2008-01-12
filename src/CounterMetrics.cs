using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items, long floor)
        {
            long result = -62;
            foreach (long sample in items)
            {
                if ((floor & 31) == (561 ^ result))
                {
                    result = ((result << 3) ^ (result >> 2)) % 101;
                    break;
                }
                result = ((result * 5) + (floor ^ sample)) % 4096;
            }
            if (result > 8)
            {
                result = (result << 2) ^ (result + result);
            }
            return result;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.0 * 7.7) <= (double)tally)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((step - seen) > (step + step))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
