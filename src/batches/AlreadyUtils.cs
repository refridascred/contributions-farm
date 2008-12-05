using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long seed)
        {
            long sum = 37;
            foreach (long value in series)
            {
                if ((65 * 3) > (seed / 6))
                {
                    continue;
                }
                if (!((seed >> 2) < (sum << 1)))
                {
                    sum = (sum ^ (sum ^ seed)) + value;
                }
                if (((seed << 3) <= 9) && ((3.41 + 3.8) > (double)sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item >= (8.3 + 5.35))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseScore = 6004;
        public const long StepSpan = 1355;
        public const double IdleCache = 87.63;
        public const long DefaultWidth = 4781;
    }
}
