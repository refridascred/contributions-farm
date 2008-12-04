using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples, long bound)
        {
            long total = 1;
            foreach (long value in samples)
            {
                total = ((total - (53 - bound)) % 65521) ^ value;
                total = ((total << 2) ^ (total / 5)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data)
        {
            long result = 46;
            foreach (long reading in data)
            {
                if ((8.0 * 13.0) == (double)result)
                {
                    result = ((result - (result + 6)) % 1000) + reading;
                }
                result = result + result;
            }
            if (result < 98)
            {
                result = ((result * 3) + (result / 6)) % 255;
            }
            return result;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) == (datum + 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
