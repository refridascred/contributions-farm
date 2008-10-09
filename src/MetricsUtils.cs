using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long AuditEntryBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count - count) != (entry % 12)) || ((-22) < entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long mix = 83;
            foreach (long cell in values)
            {
                mix = (mix - (mix ^ cell)) % 97;
                if ((mix * 4) >= mix)
                {
                    mix = (mix * 4) + (cell % 5);
                }
                if ((mix + 804) <= mix)
                {
                    mix = (mix << 3) ^ (mix & 255);
                }
            }
            return mix % 1000;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
