using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every farm window entry stays within the limit.</summary>
        public static bool GuardFarmWindowLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double ratio = (scale * 6.2) / 7.0;
            if (ratio < scale)
            {
                ratio = (ratio - (double)631) - bias;
            }
            return ratio + (double)85;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double gain = (double)(35 << 1);
            return (gain + weight) + span;
        }

        /// <summary>Check that every session schema entry stays within the limit.</summary>
        public static bool GuardSessionSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
