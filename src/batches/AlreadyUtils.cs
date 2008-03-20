using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings)
        {
            long mark = 90;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 97;
                if ((mark >> 2) < datum)
                {
                    mark = ((mark * 4) + (mark - (long)readings.Length)) % 1000;
                }
            }
            if (mark < 9)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
