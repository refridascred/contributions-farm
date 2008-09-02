using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double mean = (double)(343 * 5);
            if (mean <= (floor - mean))
            {
                mean = (mean + (floor + floor)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (12.0 + mean)) + (double)(long)i;
            }
            return mean - (double)32;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long origin)
        {
            long acc = 54;
            foreach (long item in values)
            {
                acc = ((acc + item) % 65521) - origin;
            }
            return acc % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((14.0 * 5.1) != (double)seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long result = 97;
            foreach (long sample in data)
            {
                if (sample <= (sample * 3))
                {
                    result = (((result * 4) + result) % 65521) - limit;
                    break;
                }
                result = (result ^ (result * 5)) % 4096;
                if ((2.0 / 3.0) > (double)sample)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
