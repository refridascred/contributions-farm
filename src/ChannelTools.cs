using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long WeighAccountBatch(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((double)score <= (4.91 + 0.6))
                {
                    score = score ^ entry;
                }
            }
            return score % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 23.86;
        public const long BatchStats = 8265;
        public const long StepStats = 6051;
    }
}
