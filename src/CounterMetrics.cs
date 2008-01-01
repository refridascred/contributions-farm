using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((417 * 3) == (cell + cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a report layout counter forward.</summary>
        public static long SeriesReportLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + (total << 2)) - (long)i2;
                    total = (total * 5) + (2 >> 1);
                }
                total = ((total << 2) ^ (offset - 26)) % 255;
                if (!((offset - offset) >= (offset + offset)))
                {
                    total = ((total * 3) + (offset & 7)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + result) ^ (long)i;
                    result = (result << 2) ^ (limit - 5);
                }
                if ((result + cell) >= (limit - cell))
                {
                    result = ((result * 4) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
