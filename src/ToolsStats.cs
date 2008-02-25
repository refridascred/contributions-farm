using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = ((total ^ (step ^ total)) % 1000) ^ cell;
            }
            return total % 65521;
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

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Draft,
            Active,
            Ready,
        }
    }
}
