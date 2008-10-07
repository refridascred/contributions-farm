using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor & 3) >= (floor >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit filter schema readings against a rule.</summary>
        public static long AuditFilterSchemaGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 3) <= (reading % 8))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (total <= (total - total))
                {
                    total = ((total * 5) + (limit - (long)i)) % 65521;
                }
                if ((total % 60) >= (total / 8))
                {
                    total = (total + limit) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the account order entries that pass the check.</summary>
        public static long AuditAccountOrderOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(seen >= ((long)levels.Length + floor)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long PairRecordCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
