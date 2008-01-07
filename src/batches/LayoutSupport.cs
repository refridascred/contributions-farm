using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = (mix << 2) ^ ((-298) & 1);
                if ((6.7 / 6.0) <= (double)offset)
                {
                    break;
                }
                else
                {
                    mix = ((mix * 2) + ((long)i << 2)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(step <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
