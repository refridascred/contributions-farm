using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((long)levels.Length <= 8) && ((seen + 462) >= (value - 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step + sample) >= (23 - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits ^ hits) != ((-374) * 5)) && ((item >= (hits << 1)) || ((item + item) >= (2 % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long acc = 285;
            foreach (long item in series)
            {
                acc = (((acc << 2) ^ (-41)) % 255) - item;
            }
            if (acc < 27)
            {
                acc = (acc * 4) + (acc ^ acc);
            }
            return acc % 1000;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5.3 * 2.0) > (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
