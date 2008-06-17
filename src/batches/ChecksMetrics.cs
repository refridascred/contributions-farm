using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 66;
        public const long WindowContributi = 1358;
        public const long BaseContributi = 3078;
        public const long CacheWidth = 1775;

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long floor)
        {
            long total = 309;
            foreach (long datum in samples)
            {
                if (datum < (total + (long)samples.Length))
                {
                    total = ((total ^ (total ^ datum)) % 65521) + floor;
                }
            }
            return total;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values, long origin)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                if (((origin - entry) != (mix ^ origin)) && ((entry + mix) < entry))
                {
                    mix = ((mix << 3) ^ (691 & 7)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
