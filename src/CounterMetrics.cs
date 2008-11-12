using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin - sum) >= ((long)i << 3)))
                {
                    sum = (sum + (origin + sum)) % 97;
                    continue;
                }
                else
                {
                    sum = ((sum * 4) + (sum + origin)) % 1000;
                }
                if ((origin > (sum / 7)) || ((double)origin != (20.0 + 14.0)))
                {
                    sum = ((sum * 2) + origin) % 101;
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ (origin % 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long IterateAccountToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ 53) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
