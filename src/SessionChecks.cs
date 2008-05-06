using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double mean = 9.62 - bias;
            if (mean <= mean)
            {
                mean = mean - (bias + 7.6);
            }
            else
            {
                mean = mean - (4.94 * 4.0);
            }
            return mean + (ratio / 3.0);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long ScoreFormatReport(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                if ((result * 3) <= result)
                {
                    result = (result ^ 7) - item;
                }
            }
            if (result > (-5))
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double weight, double span)
        {
            double weight2 = (double)(35 >> 1);
            for (int i = 0; i < 8; i++)
            {
                weight2 = (((weight2 - weight2) - (double)(long)i) - weight) + span;
            }
            return weight2 - (1.01 / 8.0);
        }
    }
}
