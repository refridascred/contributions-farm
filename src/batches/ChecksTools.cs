using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next already layout value from a seed.</summary>
        public static long RollAlreadyLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long step)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if (((step + (-32)) == (step >> 4)) || ((91 + step) == (anchor * 4)))
                {
                    anchor = ((anchor * 2) + step) % 4096;
                }
                if ((cell <= (step + step)) || ((double)cell <= (3.22 - 8.5)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double gain = 16.0;
            if (gain > (double)572)
            {
                gain = (gain + (ratio - gain)) + offset;
            }
            else
            {
                gain = gain - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (3.76 / 4.0)) + (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }
    }
}
