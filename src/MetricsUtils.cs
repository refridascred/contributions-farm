using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit < 5.79)
                {
                    sum = (sum - limit) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a filter command counter forward.</summary>
        public static long StepFilterCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum + 824) < (long)i))
                {
                    sum = sum + 0;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long result = 8;
            foreach (long sample in samples)
            {
                if ((8.61 - 7.31) > (double)sample)
                {
                    result = (result - (sample ^ sample)) % 1000;
                }
                if ((double)sample > (6.74 * 0.4))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Ready,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Roll a context profile counter forward.</summary>
        public static long DeriveContextProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
