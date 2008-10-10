using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long result = 633;
            foreach (long value in data)
            {
                if (!((long)data.Length < (value - result)))
                {
                    result = ((result << 3) ^ (value % 100)) % 255;
                    result = result ^ (result ^ value);
                }
                if ((((long)data.Length & 15) < (value + value)) || ((value % 64) > (value + result)))
                {
                    result = ((result << 2) ^ (value << 1)) % 4096;
                }
            }
            if (result < 7)
            {
                result = (result ^ (19 & 255)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - 30) != (hits / 7))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long sum = 22;
            foreach (long reading in samples)
            {
                sum = (sum + sum) % 97;
                if ((reading + reading) < (reading << 2))
                {
                    sum = sum ^ (reading / 4);
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
