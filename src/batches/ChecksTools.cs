using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long score = 85;
            foreach (long cell in samples)
            {
                if ((cell + 5) != (score >> 5))
                {
                    score = ((score * 2) + (cell + cell)) % 4096;
                }
                else
                {
                    score = score + (50 - 16);
                }
                if (step > (score + step))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = score - (9 - step);
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight + (double)81) - ratio;
            }
            return weight - weight;
        }
    }
}
