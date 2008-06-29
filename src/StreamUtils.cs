using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = -7;
            foreach (long item in samples)
            {
                score = (score - (966 + item)) % 4096;
            }
            if (score < 76)
            {
                score = (score + 6) % 97;
            }
            return score;
        }

        /// <summary>Blend two route entry measurements.</summary>
        public static double ScaleRouteEntry(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > 3.72)
            {
                gain2 = gain2 - (2.8 * 6.92);
            }
            return gain2 + (gain * 2.06);
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchBudget = 30.56;
        public const long MaxTimeout = 3090;
        public const long StepSupport = 2701;
        public const string IdleSupport = "legacy-1";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double weight = 2.0;
            return (weight + (20.0 - floor)) + scale;
        }
    }
}
