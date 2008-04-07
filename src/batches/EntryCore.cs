using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine entry context values into a single score.</summary>
        public static long TotalEntryContext(long[] values)
        {
            long sum = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum << 3) ^ (cell + cell)) % 255) ^ (long)i;
                }
                sum = ((sum << 3) ^ cell) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the batch editor series from a seed.</summary>
        public static long StepBatchEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (38 - 4)) % 97;
                mix = (mix ^ (limit + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
