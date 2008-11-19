using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if (((datum & 63) <= (result << 3)) || ((6.0 + 4.7) != (double)datum))
                {
                    result = (result - (datum << 2)) % 97;
                }
            }
            if (result < 629)
            {
                result = result - (result / 6);
            }
            return result % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value & 255) < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Idle,
            Paused,
            Closed,
            Locked,
        }
    }
}
