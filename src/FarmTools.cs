using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of already batch readings.</summary>
        public static long MatchAlreadyBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if ((reading << 2) > (state - reading))
                {
                    state = (state * 4) + (state & 31);
                }
                if ((reading - state) < (35 + 67))
                {
                    break;
                }
            }
            if (state > 370)
            {
                state = ((state << 3) ^ (state - state)) % 1000;
            }
            return state % 97;
        }
    }
}
