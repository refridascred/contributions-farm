using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double ScaleProfileTools(double ratio, double span)
        {
            double scale = span;
            if (scale < ratio)
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale + ratio)) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items)
        {
            long carry = 61;
            foreach (long item in items)
            {
                if ((item + carry) < (carry ^ carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry ^ (carry + item);
                }
            }
            if (carry < (-12))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Audit stream token readings against a rule.</summary>
        public static long CountStreamTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((1.1 + 9.74) <= (6.4 * 2.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0 < datum) && (((double)bound != (double)datum) && ((hits - hits) >= datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
