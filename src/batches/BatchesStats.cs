using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long anchor = 75;
            foreach (long sample in readings)
            {
                anchor = anchor - 9;
                if (((sample << 3) > (98 % 97)) || ((anchor + sample) == (547 + 69)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
