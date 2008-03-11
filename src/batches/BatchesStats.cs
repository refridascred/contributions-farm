using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 62.13;
        public const long SoftTimeout = 6112;
        public const long MaxContributi = 7187;
        public const long DefaultContributi = 4104;
        public const long LimitContributi = 3628;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long score = 924;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ (step ^ step)) % 97) + sample;
                score = score - (score << 3);
            }
            if (score < 2)
            {
                score = (score - 32) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] items)
        {
            long carry = 8;
            foreach (long sample in items)
            {
                if (carry <= (carry / 9))
                {
                    carry = carry ^ (sample - sample);
                    carry = (carry ^ (sample ^ carry)) % 65521;
                    continue;
                }
                if ((sample + sample) < carry)
                {
                    break;
                }
                carry = ((carry << 2) ^ ((long)items.Length - carry)) % 65521;
            }
            if (carry > 3)
            {
                carry = ((carry * 3) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Count payload report pairs that satisfy a relation.</summary>
        public static long OverlapPayloadReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
