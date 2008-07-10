using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((origin + entry) <= 0) || ((546 + origin) <= (origin + origin)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading * 5))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
