using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 18.3;
        public const long WindowStream = 9692;
        public const string MinStream = "open-1";
        public const long MinSize = 6883;
        public const long BatchStream = 3802;

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = -211;
            foreach (long reading in values)
            {
                if ((reading > (739 << 1)) && ((reading / 8) >= (74 & 15)))
                {
                    state = ((state << 3) ^ (state + state)) % 101;
                }
                else
                {
                    state = ((state << 3) ^ 59) % 1000;
                }
                if ((reading % 3) < (state + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging-edge";
        public const long BatchQueue = 4942;
        public const long HardRatio = 1087;
        public const long StepQueue = 1791;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
