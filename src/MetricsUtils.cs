using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((3.0 + 14.0) < (double)count) && (count < (331 / 8)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long TotalContributiSession(long[] data, long offset)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = ((carry + ((-6) + offset)) % 4096) + item;
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if (3.66 <= (double)(long)i)
                {
                    sum = ((sum * 3) + step) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
