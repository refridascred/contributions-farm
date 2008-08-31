using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((target + target) < 28)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9740;
        public const string BaseCommand = "alpha-edge";
        public const long MaxRatio = 3860;
        public const long BaseRatio = 541;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 780;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark - 408)) % 65521) - value;
                mark = (mark * 4) + (mark << 1);
            }
            if (mark > 68)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 1000;
        }
    }
}
