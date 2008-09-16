using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)(-9))
                {
                    score = score + (reading % 16);
                }
            }
            if (score < 9)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score;
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
