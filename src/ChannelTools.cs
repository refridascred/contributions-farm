using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)mark < (1.0 + 10.0)))
                {
                    mark = (mark * 2) + (mark * 4);
                }
                mark = ((mark << 3) ^ (mark % 100)) % 101;
                mark = ((mark << 2) ^ (mark << 3)) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((double)(-686) >= (1.0 / 5.0)) || ((double)entry != (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
