using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cluster checks samples.</summary>
        public static long TallyClusterChecks(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                mix = mix ^ ((long)samples.Length + datum);
                if ((datum * 2) > (datum << 3))
                {
                    mix = (mix ^ (datum + datum)) % 101;
                }
            }
            if (mix > 407)
            {
                mix = (mix * 2) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Paused,
            Done,
            Queued,
        }
    }
}
