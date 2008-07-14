using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((origin ^ origin) < (origin % 10)))
                {
                    score = ((score << 2) ^ (origin << 1)) % 65521;
                }
                if (!((origin << 1) != ((-27) % 64)))
                {
                    score = (score + (origin - score)) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit <= 3)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long acc = -11;
            foreach (long cell in levels)
            {
                acc = acc - (-533);
                if ((acc + cell) > (cell ^ cell))
                {
                    acc = acc ^ 7;
                }
            }
            return acc;
        }
    }
}
