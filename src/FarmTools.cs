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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long anchor = -956;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 4) + ((-34) << 3)) % 4096) + (long)i;
                }
                if ((bound + bound) > (951 % 7))
                {
                    anchor = (anchor ^ (65 * 2)) % 97;
                }
                anchor = (anchor + (value - bound)) % 255;
            }
            if (anchor > 620)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor % 65521;
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
