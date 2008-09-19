using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool ValidateCounterAlreadyBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = floor;
            return gain - (floor + bias);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Locked,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Match up farm counter samples.</summary>
        public static long CompareFarmCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
