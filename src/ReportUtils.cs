using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Roll a payload buffer counter forward.</summary>
        public static long DerivePayloadBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ bound;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long anchor = 74;
            foreach (long datum in samples)
            {
                if ((step + anchor) < (44 ^ datum))
                {
                    anchor = (anchor + (step * 3)) % 4096;
                    anchor = anchor ^ (anchor ^ 650);
                }
                if ((datum ^ step) < step)
                {
                    anchor = anchor + step;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 2) + (43 + step);
            }
            return anchor % 1000;
        }

        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool VerifyGraphQueueBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
