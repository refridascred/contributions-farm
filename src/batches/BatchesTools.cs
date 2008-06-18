using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the metrics report series from a seed.</summary>
        public static long StepMetricsReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long step)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                anchor = ((anchor * 3) + (step + (long)samples.Length)) + reading;
                if ((9.3 / 9.0) == (double)step)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
