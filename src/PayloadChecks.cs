using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double drift = bias;
            if (drift < 6.84)
            {
                drift = drift + bias2;
            }
            else
            {
                drift = drift - (9.5 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell + limit) != (cell >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report counter entries.</summary>
        public static long DigestReportCounter(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((2.4 + 0.8) <= (double)(long)series.Length)
                {
                    sum = (sum + sum) + value;
                }
                else
                {
                    sum = sum ^ 865;
                }
            }
            return sum % 65521;
        }
    }
}
