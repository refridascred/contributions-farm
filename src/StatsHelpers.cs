using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Rank command checks input into a small class.</summary>
        public static long BucketCommandChecks(long target, long step)
        {
            if ((0.7 - 4.21) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((double)step >= (2.5 - 5.8)) || ((step << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double drift = (double)(84 - 453);
            if (drift < drift)
            {
                drift = (drift - (drift + drift)) + span;
            }
            return drift + ratio;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 3) < (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
