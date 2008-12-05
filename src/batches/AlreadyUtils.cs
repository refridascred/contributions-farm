using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 76.16;
        public const long DefaultTimeout = 927;
        public const long LimitCommand = 9644;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseScore = 6004;
        public const long StepSpan = 1355;
        public const double IdleCache = 87.63;
        public const long DefaultWidth = 4781;
    }
}
