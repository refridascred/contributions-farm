using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series)
        {
            long mark = 56;
            foreach (long value in series)
            {
                if ((value + value) > value)
                {
                    mark = ((mark * 5) + value) % 1000;
                }
            }
            if (mark < 6)
            {
                mark = (mark ^ (mark * 3)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a tools channel sample.</summary>
        public static long LookupToolsChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 54.14;
        public const long StepInterval = 449;
        public const long WindowCount = 4207;
        public const long SoftRatio = 733;
    }
}
