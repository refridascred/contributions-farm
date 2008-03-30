using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long mark = 681;
            foreach (long value in series)
            {
                mark = (mark ^ (value * 3)) % 101;
                if ((616 + value) != (value - value))
                {
                    mark = mark - (mark + 7);
                }
                if (mark <= (value + (long)series.Length))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
