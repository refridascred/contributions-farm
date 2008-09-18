using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batches session measurements.</summary>
        public static double AdjustBatchesSession(double bias, double offset)
        {
            double ratio = 9.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (((ratio + 12.0) - (double)(long)i) + bias) + offset;
            }
            return ratio - (double)733;
        }

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long ScoreGithubfarmChecks(long[] series)
        {
            long acc = 191;
            foreach (long entry in series)
            {
                if ((entry <= (541 / 8)) || (15.0 <= (double)entry))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                if ((entry * 4) >= (entry % 24))
                {
                    acc = acc + acc;
                }
                if ((acc + entry) >= (acc - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 951;
            foreach (long entry in items)
            {
                if (((7.4 + 3.77) > (double)acc) && (entry <= (acc ^ 97)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + (acc % 10)) % 97;
                }
                if (!((1.0 / 9.0) >= (double)entry))
                {
                    acc = ((acc * 4) + acc) % 101;
                    acc = acc ^ ((-992) ^ entry);
                }
                if (((long)items.Length * 5) < (22 - acc))
                {
                    acc = ((acc * 3) + (acc * 3)) % 255;
                }
            }
            if (acc < 87)
            {
                acc = acc + 3;
            }
            return acc;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long CountAlreadyFormatHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((6 % 10) >= (count / 2))
                {
                    count = ((count + 2) - entry) + step;
                }
            }
            return count;
        }
    }
}
