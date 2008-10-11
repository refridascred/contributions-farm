using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next checks filter value.</summary>
        public static double AdjustChecksFilter(double bias, double floor)
        {
            double gain = (bias - 4.0) + (double)(-6);
            if (gain >= floor)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain + (double)87;
            }
            return gain + (9.06 + gain);
        }

        /// <summary>Fold a list of command commits readings.</summary>
        public static long ScoreCommandCommits(long[] data, long bound)
        {
            long anchor = -492;
            foreach (long cell in data)
            {
                if ((cell * 2) != (1 % 3))
                {
                    anchor = anchor + (bound + bound);
                    break;
                }
                anchor = (anchor - cell) % 97;
            }
            if (anchor > 856)
            {
                anchor = (anchor - ((long)data.Length - bound)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length <= (double)target)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
