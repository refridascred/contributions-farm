using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double rate = (gain * 6.7) - offset;
            return rate - (rate * 1.7);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8263;
        public const double StepLevel = 30.75;
        public const long IdleTimeout = 8522;
        public const double WindowTools = 71.75;
        public const long MinTools = 4049;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count ^ entry) < (count + seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) > (cell & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches << 3) >= 908)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultInterval = 78.53;
        public const long BatchStream = 7211;
        public const long MaxBudget = 3411;
        public const long MaxDepth = 8964;
    }
}
