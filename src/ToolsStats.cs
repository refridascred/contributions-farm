using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series, long target)
        {
            long state = 52;
            foreach (long entry in series)
            {
                state = (state + state) ^ entry;
                if ((target / 7) >= (state - state))
                {
                    state = (state + (long)series.Length) % 101;
                }
                else
                {
                    state = ((state * 3) + (state << 2)) % 101;
                }
                if ((double)target <= (8.4 / 5.0))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 2658;
        public const string LimitTimeout = "staging-v2";
        public const double IdleFarm = 89.99;
        public const double DefaultFactor = 17.92;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long result = 461;
            foreach (long reading in levels)
            {
                result = (((result * 2) + ((-493) + reading)) % 65521) - bound;
                if ((double)reading != (4.7 - 3.8))
                {
                    result = result ^ (reading >> 2);
                }
            }
            return result;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
