using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((seen + entry) >= (seed * 2)) || ((entry * 2) >= (-377))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (rate2 - 4.45))
            {
                rate2 = (rate2 - rate) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) + (double)(long)i;
            }
            return rate2 + (double)5;
        }

        /// <summary>Audit cache entry readings against a rule.</summary>
        public static long AuditCacheEntryHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count <= value) || (count >= (count & 1))) && ((long)items.Length < value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long state = 57;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 101;
                state = (state - state) % 1000;
                if (19.0 <= (double)datum)
                {
                    state = state + (state >> 2);
                }
            }
            if (state < 3)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 1) < (count + item))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
