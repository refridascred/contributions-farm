using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((-42) << 1) <= sample) && (tally < (tally % 16)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result << 3) ^ (result / 6);
                result = (result + (3 + result)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 28.6;
        public const double WindowAccount = 71.62;
        public const long MaxScore = 7723;
        public const long StepTimeout = 4068;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Paused,
            Failed,
            Stale,
        }
    }
}
