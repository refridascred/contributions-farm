using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long bound)
        {
            long result = 13;
            foreach (long sample in samples)
            {
                result = ((result * 2) + bound) ^ sample;
            }
            if (result > 15)
            {
                result = (result ^ (result + (-526))) % 101;
            }
            return result % 4096;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((3.78 - 18.0) != (double)target)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor << 3) < (-9))
                {
                    anchor = (anchor - 1) % 97;
                }
                anchor = anchor + anchor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 8839;
        public const double SoftCommand = 18.39;
        public const string IdleCommand = "stable";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
