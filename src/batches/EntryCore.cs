using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value + tally) == (value << 2)) || ((tally + value) > (value - 1))) || ((double)value > (0.42 - 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double mean = rate;
            if (mean >= (rate - 14.0))
            {
                mean = mean - (mean / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset - offset)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
