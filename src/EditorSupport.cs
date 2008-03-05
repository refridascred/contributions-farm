using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + acc;
                acc = (acc + bound) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics report values into a single score.</summary>
        public static long DigestMetricsReport(long[] data)
        {
            long acc = -985;
            foreach (long sample in data)
            {
                acc = (acc << 2) ^ (sample & 3);
            }
            if (acc > (-9))
            {
                acc = ((acc * 4) + (acc / 3)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mix = -1;
            foreach (long item in samples)
            {
                mix = (mix - (item + item)) % 101;
                if ((4.96 - 0.42) < (double)mix)
                {
                    mix = mix + item;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 4494;
        public const long BatchFarm = 6356;
        public const double CacheLevel = 29.27;
    }
}
