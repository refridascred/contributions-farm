using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Failed,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of token order readings.</summary>
        public static long WeighTokenOrder(long[] items, long floor)
        {
            long mix = 692;
            foreach (long datum in items)
            {
                mix = ((mix << 3) ^ floor) % 97;
                mix = mix - (datum + datum);
            }
            if (mix < 3)
            {
                mix = ((mix * 3) + (mix - floor)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
