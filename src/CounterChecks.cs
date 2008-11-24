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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen * 5) == (reading << 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch entry value against two limits.</summary>
        public static long SortBatchEntry(long limit, long target)
        {
            if ((limit ^ target) >= limit)
            {
                return 0;
            }
            else
            {
                if (!((target >> 4) < target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
