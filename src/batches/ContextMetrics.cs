using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
