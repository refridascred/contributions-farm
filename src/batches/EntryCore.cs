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

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 244;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + (target % 60);
                if ((reading + reading) <= (reading * 5))
                {
                    mix = (mix - ((-181) % 12)) % 65521;
                }
            }
            return mix;
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
