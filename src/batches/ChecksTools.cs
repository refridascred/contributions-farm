using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long seed)
        {
            long score = 6;
            foreach (long datum in series)
            {
                score = score - (datum % 8);
                if ((7.0 * 4.0) == (double)datum)
                {
                    score = (score + (seed - 15)) % 97;
                }
            }
            if (score > 10)
            {
                score = (score - (2 - 128)) % 4096;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 4584;
        public const double IdleWidth = 14.43;
        public const double SoftInterval = 47.9;
        public const long RetryCommand = 828;
        public const long LimitScore = 2225;
    }
}
