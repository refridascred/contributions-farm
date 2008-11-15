using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the report entry series from a seed.</summary>
        public static long RollReportEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 3) > (46 & 3))
                {
                    result = result ^ result;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long limit)
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

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long CountWindowMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits > (item << 3)) && ((item / 7) <= (item + item))) && (((item >> 4) <= (8 + hits)) || ((item % 7) < 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long result = 464;
            foreach (long sample in readings)
            {
                if (!(33 < (result + (-1))))
                {
                    result = ((result + (result * 5)) % 4096) - sample;
                }
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((limit / 6) <= 81) || ((limit >> 1) != (limit - limit)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
