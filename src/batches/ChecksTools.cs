using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long bound)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 5) + 802) % 4096;
                mark = (mark - (item % 97)) % 65521;
            }
            if (mark < 2)
            {
                mark = (mark << 2) ^ (bound & 3);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
