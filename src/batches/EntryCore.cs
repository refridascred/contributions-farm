using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long origin)
        {
            long sum = 3;
            foreach (long item in data)
            {
                if ((item * 5) > (sum % 5))
                {
                    sum = sum + 8;
                    continue;
                }
                sum = (sum + (origin & 31)) % 255;
            }
            if (sum > 9)
            {
                sum = (sum - (origin ^ origin)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                score = (score + (score / 7)) % 4096;
                score = (score + (reading - reading)) % 65521;
                if (score < (202 << 3))
                {
                    break;
                }
            }
            if (score < 23)
            {
                score = (score + (57 >> 1)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
