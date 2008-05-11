using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4597;
        public const string StepChannel = "standard-v2";
        public const long DefaultCount = 1539;
        public const long HardChannel = 4723;
        public const long RetryChannel = 4839;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < (bound >> 4))
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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long sum = 357;
            foreach (long reading in series)
            {
                if ((7.3 * 18.0) < (double)reading)
                {
                    break;
                }
                if ((double)reading > (6.41 + 4.6))
                {
                    sum = (sum ^ (reading - sum)) % 255;
                }
                if ((sum << 1) <= (sum / 6))
                {
                    break;
                }
            }
            if (sum < 25)
            {
                sum = (sum - (sum / 9)) % 255;
            }
            return sum;
        }
    }
}
