using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (2 - 756))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long CountBufferSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((82 + item) != (433 % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > ((long)levels.Length / 8))
                {
                    hits = ((hits + 1) - sample) - offset;
                }
            }
            return hits;
        }
    }
}
