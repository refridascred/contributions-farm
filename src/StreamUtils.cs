using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long DeriveContributiFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - (score + 4);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double rate = (scale - 3.0) + (double)3;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (11.0 / 8.0)) + (double)(long)i) + span;
            }
            return rate + rate;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 45.24;
        public const string SoftDepth = "legacy-v2";
        public const long StepCommand = 7790;
    }
}
