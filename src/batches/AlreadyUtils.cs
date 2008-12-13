using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 6370;
        public const long MaxLayout = 7281;
        public const string HardLayout = "alpha-1";
        public const string IdleBudget = "alpha-v2";

        /// <summary>Check that every buffer notes entry stays within the limit.</summary>
        public static bool VerifyBufferNotesBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double rate = bias;
            if (rate < scale)
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (rate - bias);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "fallback-v2";
        public const double WindowSize = 73.52;
        public const long HardSession = 9107;
        public const long LimitRatio = 1339;

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
