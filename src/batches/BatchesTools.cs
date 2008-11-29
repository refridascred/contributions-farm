using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ hits) < (reading % 60))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report checks series from a seed.</summary>
        public static long RollReportChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                long delta = (long)i - (7 & 7);
                if ((target - (-72)) < (delta / 9))
                {
                    acc = ((acc * 2) + (delta ^ delta)) % 97;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Paused,
            New,
        }
    }
}
