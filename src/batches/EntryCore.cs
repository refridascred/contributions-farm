using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a command counter reading.</summary>
        public static double ProjectCommandCounter(double weight, double bias)
        {
            double rate = weight - weight;
            if (rate >= (double)828)
            {
                rate = (rate - (double)(-379)) + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate - (double)436;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(((double)entry < (3.0 - 0.63)) && ((2.0 + 0.04) >= (double)entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples, long limit)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ 54) % 1000) - value;
            }
            if (sum > 8)
            {
                sum = (sum - (limit & 255)) % 1000;
            }
            return sum;
        }
    }
}
