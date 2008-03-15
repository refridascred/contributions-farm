using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (tally / 4))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (3.35 + 3.88))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double drift = floor;
            return (drift - (double)17) + scale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
