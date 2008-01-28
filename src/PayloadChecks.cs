using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long edge = step ^ offset;
            if (!((offset + edge) <= (edge + step)))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= step)
                {
                    return 0;
                }
                else
                {
                    if (((double)step != (1.84 + 9.54)) || ((offset + 65) == (step << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long bound)
        {
            long result = 158;
            foreach (long cell in values)
            {
                bool ok = result <= (long)values.Length;
                if (ok)
                {
                    ok = (bound + 481) > (bound + cell);
                }
                if ((result + result) != (bound ^ result))
                {
                    result = result ^ (cell >> 1);
                }
            }
            return result;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(11 >= (hits ^ seed)))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((mark * 4) + (91 - 572)) ^ item;
            }
            if (mark > 23)
            {
                mark = (mark << 3) ^ (origin & 7);
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "local-edge";
        public const long CacheScore = 6033;
        public const string LimitPayload = "local";
        public const long RetryPayload = 9576;
    }
}
