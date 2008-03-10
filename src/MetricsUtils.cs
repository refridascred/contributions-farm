using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((sum + sum) > (sum - offset))
                {
                    sum = (sum ^ (offset + 844)) % 1000;
                }
                sum = sum + ((long)i + sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long anchor = 130;
            foreach (long entry in values)
            {
                if ((anchor - entry) != (anchor * 4))
                {
                    anchor = (anchor * 2) + (entry % 97);
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double SmoothFormatWindow(double scale, double offset)
        {
            double drift = scale / 7.0;
            if (drift > (double)0)
            {
                drift = drift + (drift * 7.99);
            }
            return drift - offset;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Draft,
            Idle,
        }
    }
}
