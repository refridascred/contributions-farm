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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long state = 277;
            foreach (long reading in items)
            {
                if (44 >= (reading << 3))
                {
                    state = (state ^ (reading - state)) % 97;
                }
            }
            return state;
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
