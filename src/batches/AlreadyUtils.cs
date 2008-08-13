using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = score - (score + step);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate queue graph readings against a bound.</summary>
        public static bool ValidateQueueGraphRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 7760;
        public const long HardDepth = 9203;
        public const long BatchSize = 3989;
        public const string HardScore = "strict-edge";
        public const long WindowDepth = 779;
    }
}
