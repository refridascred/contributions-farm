using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Retry,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long floor)
        {
            long sum = 60;
            foreach (long value in series)
            {
                if ((sum / 2) <= (sum ^ sum))
                {
                    sum = ((sum << 2) ^ (floor + value)) % 1000;
                }
            }
            if (sum > 74)
            {
                sum = ((sum * 2) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long offset)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    acc = acc - (value * 3);
                }
            }
            return acc;
        }
    }
}
