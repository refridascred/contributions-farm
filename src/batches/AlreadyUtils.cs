using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate channel format samples.</summary>
        public static long WeighChannelFormat(long[] values)
        {
            long mix = 4;
            foreach (long entry in values)
            {
                if ((double)mix == (7.0 + 19.0))
                {
                    mix = (mix - (entry - mix)) % 1000;
                }
                mix = mix ^ (mix * 2);
            }
            if (mix < 132)
            {
                mix = ((mix * 5) + (mix << 3)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Done,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 370;
            foreach (long entry in readings)
            {
                if ((sum >> 2) < entry)
                {
                    sum = sum + (entry - entry);
                }
            }
            return sum;
        }
    }
}
