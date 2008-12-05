using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up commits account samples.</summary>
        public static long PairCommitsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ (11 + limit);
                if (carry >= (carry * 2))
                {
                    carry = ((carry << 3) ^ (carry & 127)) % 101;
                }
                carry = (carry - (carry >> 3)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(77 < (hits & 1)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
