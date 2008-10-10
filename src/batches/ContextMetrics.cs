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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + origin) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Roll a notes account counter forward.</summary>
        public static long SeriesNotesAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ total;
                if (((long)i - 0) > (total / 5))
                {
                    total = total ^ (0 % 7);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
