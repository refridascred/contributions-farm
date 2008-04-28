using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = 7.1;
            if (scale <= (span * 6.0))
            {
                scale = (scale + (span * 9.19)) + bias;
            }
            else
            {
                scale = scale + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(-77)) - (double)(long)i;
            }
            return scale + (double)20;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
