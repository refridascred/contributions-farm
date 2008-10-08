using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Locked,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double mean = (gain + offset) + (gain - offset);
            if (mean >= gain)
            {
                mean = mean - 3.2;
            }
            else
            {
                mean = mean - 9.18;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (offset * 0.26)) + (double)(long)i;
            }
            return mean - (gain * 3.0);
        }
    }
}
