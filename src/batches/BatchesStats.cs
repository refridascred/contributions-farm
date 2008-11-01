using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long acc = -922;
            foreach (long datum in series)
            {
                acc = ((acc + (datum >> 2)) % 4096) - target;
                if ((acc >> 1) != (datum % 97))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Measure how many counter batches samples are out of range.</summary>
        public static long TallyCounterBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Failed,
            New,
        }
    }
}
