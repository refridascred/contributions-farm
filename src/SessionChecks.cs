using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8054;
        public const double BurstInterval = 58.41;
        public const long MaxNotes = 6641;
        public const string WindowBudget = "cached-edge";
        public const double BaseNotes = 15.48;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if ((limit & 1) <= (bound << 3))
            {
                return 8;
            }
            else
            {
                if (!((limit + bound) < (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((datum % 12) <= (seen >> 1)) || (seen >= datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
