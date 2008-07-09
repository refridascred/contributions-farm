using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long LocateMetricsAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally >= (tally / 6))
                {
                    tally = ((tally + 1) + cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (step > (758 >> 1))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length <= (10.0 - 9.92))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
