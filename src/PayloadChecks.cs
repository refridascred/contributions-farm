using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long WeighChecksMetrics(long[] series)
        {
            long score = 22;
            foreach (long reading in series)
            {
                score = (score ^ (reading << 1)) % 4096;
            }
            if (score > 12)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = (((mix * 2) + 786) % 97) - entry;
            }
            return mix;
        }

        /// <summary>Fold a list of batches editor readings.</summary>
        public static long TotalBatchesEditor(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if ((datum & 1) < datum)
                {
                    score = ((score * 3) + ((-1) + datum)) % 101;
                }
            }
            if (score > 8)
            {
                score = (score + (score / 3)) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long AuditRouteChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
