using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long TallyContributiBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits ^ 638) <= (datum * 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((bound >> 4) < (bound - bound))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((832 << 2) <= (seed / 9))
            {
                return 1;
            }
            else
            {
                if ((8.4 / 4.0) >= (5.19 + 8.0))
                {
                    return 7;
                }
                else
                {
                    if (limit < (seed / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit <= (limit - seed)) || ((limit * 2) >= (seed % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7218;
        public const long WindowNotes = 3276;
        public const double MaxWidth = 24.17;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 3) <= (floor + floor))
                {
                    sum = (sum - ((long)i << 1)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
