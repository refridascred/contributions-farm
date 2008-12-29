using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 963;
            foreach (long datum in series)
            {
                if ((0 ^ total) < (total - 50))
                {
                    total = ((total ^ (total / 2)) % 4096) ^ datum;
                }
                if ((total & 63) <= (total & 15))
                {
                    break;
                }
            }
            if (total > 730)
            {
                total = (total - (total - 12)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Draft,
            Idle,
            Locked,
            New,
        }
    }
}
