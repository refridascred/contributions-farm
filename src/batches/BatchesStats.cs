using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 3426;
        public const double HardSize = 20.82;
        public const long MinSupport = 3317;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series, long target)
        {
            long sum = 44;
            foreach (long value in series)
            {
                if ((double)target != (1.9 * 4.71))
                {
                    sum = ((sum - (2 << 1)) % 255) - value;
                }
            }
            if (sum > (-7))
            {
                sum = (sum + target) % 65521;
            }
            return sum;
        }
    }
}
