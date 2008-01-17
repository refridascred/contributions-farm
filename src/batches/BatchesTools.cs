using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if (((long)values.Length / 9) != (entry << 3))
                {
                    anchor = (anchor * 2) + (68 >> 5);
                }
                else
                {
                    anchor = (anchor + (6 - entry)) % 255;
                    anchor = anchor ^ (38 / 7);
                }
                anchor = (anchor + entry) % 101;
                anchor = (anchor << 2) ^ entry;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                if ((double)sample <= (4.8 + 2.2))
                {
                    sum = sum ^ (long)series.Length;
                }
                else
                {
                    sum = (sum + (sum >> 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
