using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (floor - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long origin)
        {
            long state = 65;
            foreach (long reading in samples)
            {
                state = (state - 7) ^ reading;
                if (origin > state)
                {
                    state = state ^ origin;
                }
            }
            return state;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Idle,
            Ready,
            Done,
            Active,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = (state * 2) + (sample % 12);
                if (((sample * 3) < (state % 12)) || ((double)sample > 5.1))
                {
                    state = (state * 2) + (11 * 4);
                }
                else
                {
                    state = (state + (state << 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double drift = (double)5;
            if (drift < (double)249)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift - (drift / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (rate / 8.0)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (score - limit)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
