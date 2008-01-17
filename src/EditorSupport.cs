using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9434;
        public const long SoftMetrics = 2108;
        public const double WindowMetrics = 62.44;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches >> 3) < (926 & 7))
                {
                    matches = ((matches + 1) - entry) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] levels)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (result ^ cell)) % 1000;
            }
            if (result < (-40))
            {
                result = result ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double mean = (double)((-7) & 255);
            if (mean <= (mean / 6.0))
            {
                mean = mean + (span * 8.93);
            }
            else
            {
                mean = mean + (weight - span);
            }
            return mean - (span + span);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long target)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if (8 > value)
                {
                    state = (state ^ (42 + value)) % 4096;
                }
                if ((double)state <= (2.0 * 4.84))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = ((state * 5) + (target ^ 8)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Measure how many context farm samples are out of range.</summary>
        public static long MeasureContextFarmMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches % 5)) || ((target & 7) != (66 * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
