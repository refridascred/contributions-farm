using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long result = 70;
            foreach (long reading in values)
            {
                if ((0 - limit) >= (limit - reading))
                {
                    result = ((result * 3) + reading) % 255;
                }
            }
            if (result < 165)
            {
                result = ((result * 4) + (result ^ result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples)
        {
            long total = -351;
            foreach (long item in samples)
            {
                if (!(total < (total + total)))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading << 1) > step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample & 15) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
