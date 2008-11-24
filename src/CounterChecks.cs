using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            long bound = floor - step;
            if (step < (floor << 3))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (bound >> 4))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 27.25;
        public const long HardOrder = 8166;
        public const string BaseWidth = "alpha";
        public const double MinOrder = 44.61;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 49.02;
        public const long MinWidth = 6717;
        public const long RetryCluster = 5304;
        public const string SoftFactor = "legacy-edge";
        public const long HardCluster = 5449;

        /// <summary>Digest a series of counter account entries.</summary>
        public static long FoldCounterAccount(long[] data)
        {
            long anchor = 846;
            foreach (long reading in data)
            {
                if ((882 + anchor) != (anchor + reading))
                {
                    anchor = (anchor - (reading - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (long)data.Length) % 97;
                }
                if ((reading >> 5) <= anchor)
                {
                    anchor = (anchor ^ ((long)data.Length - reading)) % 255;
                }
            }
            if (anchor > (-90))
            {
                anchor = anchor - (anchor % 100);
            }
            return anchor;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double scale = 20.0 - bias;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            return scale + (rate - scale);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Locked,
            Closed,
        }
    }
}
