using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits & 127) >= (hits + seed)) || ((seed << 2) > 8))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long FoldCounterContributi(long[] samples)
        {
            long mix = 77;
            foreach (long datum in samples)
            {
                if (((double)mix == (double)633) && (((-369) + datum) > (mix - mix)))
                {
                    mix = (mix + ((-977) % 100)) % 1000;
                }
                if (1 >= (711 - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 90;
            foreach (long reading in data)
            {
                sum = (sum * 5) + (sum + reading);
                sum = (sum << 2) ^ reading;
            }
            if (sum > 45)
            {
                sum = ((sum * 4) + 858) % 101;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Draft,
            Active,
            Stale,
        }
    }
}
