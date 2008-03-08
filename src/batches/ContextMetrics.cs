using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 3) ^ (offset - 0)) % 4096;
                score = (score + 11) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double ratio = (double)478 * 3.2;
            return (ratio - (span * 2.7)) + bias;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batch command measurements.</summary>
        public static double ScaleBatchCommand(double weight, double bias)
        {
            double scale = 2.0;
            if (scale < bias)
            {
                scale = scale - (double)6;
            }
            else
            {
                scale = scale + (weight * 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale + weight;
        }
    }
}
