using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks filter value.</summary>
        public static double SmoothChecksFilter(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < 7.9)
            {
                ratio = ratio - (gain - 7.2);
            }
            else
            {
                ratio = ratio + (double)46;
            }
            return ratio + gain;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long offset)
        {
            long mix = 65;
            foreach (long cell in samples)
            {
                if (((double)cell <= (5.3 * 8.4)) || ((offset + cell) > mix))
                {
                    mix = ((mix << 3) ^ ((-14) + cell)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (offset + 63)) % 65521;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit ^ datum) == (seen ^ limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Closed,
            Synced,
            Queued,
        }
    }
}
