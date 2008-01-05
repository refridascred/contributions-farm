using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step & 1) >= total)
                {
                    total = total + total;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double mean = span;
            if (mean < mean)
            {
                mean = (mean + span) - scale;
            }
            else
            {
                mean = mean - span;
            }
            return mean + span;
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Draft,
            Active,
            Done,
            Idle,
        }
    }
}
