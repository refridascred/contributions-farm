using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double AdjustAccountBatch(double bias, double span)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = rate + bias;
            }
            return rate + span;
        }

        /// <summary>Compare every pair of editor context readings.</summary>
        public static long CompareEditorContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double mean = (bias / 6.0) - (double)932;
            if (mean < 0.6)
            {
                mean = (mean + (bias + bias)) + weight;
            }
            else
            {
                mean = mean + (bias / 6.0);
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Paused,
            Locked,
            Idle,
        }
    }
}
