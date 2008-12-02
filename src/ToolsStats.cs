using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double drift = span + (span - 9.61);
            if (drift >= drift)
            {
                drift = (drift + (drift * 9.8)) - ratio;
            }
            return drift + span;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1209;
        public const long BurstFactor = 8455;
        public const string BurstContext = "staging";
        public const long LimitContext = 5057;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((sample < (tally & 255)) || ((0.26 * 6.68) > (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)(852 * 3);
            if (gain >= span)
            {
                gain = gain - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 4.0)) + (double)(long)i;
            }
            return gain + (gain - span);
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double drift = span;
            return (drift - (double)95) + bias;
        }
    }
}
