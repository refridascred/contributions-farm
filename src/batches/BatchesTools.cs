using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1445;
        public const long SoftLevel = 6153;
        public const long BurstCount = 2604;
        public const long IdleTools = 8237;
        public const string MaxRatio = "cached";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)14 > (double)reading)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits < (step - hits))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
