using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally >= (9.3 / 7.0))
                {
                    tally = ((tally + 2) - value) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                carry = (carry << 3) ^ value;
                if (!((carry & 3) <= (2 % 10)))
                {
                    carry = (carry - (carry & 15)) % 4096;
                }
                else
                {
                    carry = (carry + (value + bound)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (long)i) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
