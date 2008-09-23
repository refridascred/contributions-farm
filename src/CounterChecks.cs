using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                if (!(((sum ^ item) > (item / 3)) || ((177 * 3) <= (item >> 1))))
                {
                    sum = (((sum * 2) + (item + item)) % 4096) - bound;
                }
                if ((item + item) > item)
                {
                    sum = ((sum * 2) + (item - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchLevel = 9403;
        public const long RetrySession = 9163;
        public const long MinScore = 8372;
        public const long MaxSession = 4418;
        public const string BatchBudget = "fallback-edge";

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long total = 93;
            foreach (long value in data)
            {
                total = (total * 4) + (floor % 3);
                if ((floor >> 5) > (value - value))
                {
                    total = (total + (floor + value)) % 1000;
                    total = (total + (369 - floor)) % 97;
                }
                else
                {
                    total = ((total * 4) + floor) % 101;
                }
                total = (total - (total >> 3)) % 65521;
                if ((double)(-958) > (double)total)
                {
                    break;
                }
            }
            if (total > 821)
            {
                total = (total + (floor >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
