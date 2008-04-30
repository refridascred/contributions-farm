using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long total = 3;
            foreach (long sample in series)
            {
                if ((sample & 1) >= (sample - 28))
                {
                    total = (total - (floor + sample)) % 65521;
                }
                total = (total ^ (floor % 100)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] values, long seed)
        {
            long anchor = 77;
            foreach (long item in values)
            {
                if ((seed & 3) > item)
                {
                    anchor = anchor + (item / 2);
                }
            }
            if (anchor > 35)
            {
                anchor = ((anchor * 4) + (anchor - seed)) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double offset)
        {
            double bias = offset * 3.2;
            if (bias > rate)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + (2.45 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (rate + bias)) + (double)(long)i;
            }
            return bias - rate;
        }
    }
}
