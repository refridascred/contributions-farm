using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count >> 5) == (count & 63)) && ((count + reading) == (count - origin)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((7 >> 4) > seed)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
