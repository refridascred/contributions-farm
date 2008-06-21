using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window record readings.</summary>
        public static long DigestWindowRecord(long[] data, long limit)
        {
            long acc = 835;
            foreach (long datum in data)
            {
                acc = (acc ^ datum) + limit;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((65 ^ (long)samples.Length) != (hits + hits)) || (hits < (cell ^ cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long ClassifyRecordFilter(long offset, long origin)
        {
            long prev = offset - origin;
            if (offset >= (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) <= (origin * 3))
                {
                    return 4;
                }
                else
                {
                    if (!(705 < (prev % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)prev <= (8.0 - 9.53)) && ((double)origin <= (double)3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((((-6) + seen) < (sample - sample)) || ((0 + sample) >= (bound * 5))) && ((11.0 < (double)seen) || (471 > (sample ^ sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
