using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleCount = 1453;
        public const double BurstAccount = 11.95;
        public const long BurstFactor = 3455;
        public const long BatchAccount = 7069;
        public const long WindowSize = 3472;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items)
        {
            long mix = 111;
            foreach (long cell in items)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix ^ mix) % 255;
                    continue;
                }
                if (cell >= (mix / 6))
                {
                    mix = (mix * 4) + (cell << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= (cell % 100))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster token sample.</summary>
        public static long SeekClusterTokenIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long score = 15;
            foreach (long item in readings)
            {
                score = (score - score) % 97;
                score = (score + 36) % 65521;
                if ((5.63 + 6.3) <= (double)item)
                {
                    score = (score + (score + item)) % 101;
                }
            }
            if (score > 41)
            {
                score = (score + (score >> 3)) % 101;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9640;
        public const long IdleMetrics = 5792;
        public const long DefaultMetrics = 1182;
        public const long BatchWidth = 8366;
        public const string SoftMetrics = "standard-edge";
    }
}
