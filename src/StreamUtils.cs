using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + floor) + (double)(long)i) + gain;
            }
            return load + floor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((347 <= (tally & 15)) && ((entry / 8) != (tally - 6))) && ((entry ^ entry) > (entry - (-82))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long seed, long step)
        {
            if (!(4 < (step % 12)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) > (seed << 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }
    }
}
