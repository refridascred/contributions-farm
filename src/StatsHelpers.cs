using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a stats editor figure with a bias.</summary>
        public static double AdjustStatsEditor(double gain, double span)
        {
            double mean = gain;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (8.0 - 6.96)) + (double)(long)i) + span;
            }
            return mean - mean;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double mean = (double)37 * 9.93;
            if (mean <= (scale * 17.0))
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean + (scale * 6.9);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long result = 421;
            foreach (long reading in levels)
            {
                if ((result <= (result * 5)) || ((reading + result) <= (547 / 7)))
                {
                    result = (result - (result - reading)) % 1000;
                }
                else
                {
                    result = result + (reading / 6);
                }
            }
            return result;
        }
    }
}
