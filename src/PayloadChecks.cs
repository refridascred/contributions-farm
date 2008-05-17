using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long origin)
        {
            long score = 3;
            foreach (long datum in data)
            {
                if (((origin / 3) < (datum + origin)) && ((origin / 6) >= (datum / 2)))
                {
                    score = score - (score - datum);
                    score = score + (datum + score);
                    break;
                }
                score = (score << 2) ^ score;
            }
            if (score > 1)
            {
                score = score ^ (score ^ score);
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool CheckLayoutSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Done,
            Retry,
            Active,
        }

        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long MeasureNotesChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.47 + 7.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
