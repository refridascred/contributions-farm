using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double load = (double)(214 - 19);
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias - load)) + (double)(long)i;
            }
            return load - (weight - load);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
