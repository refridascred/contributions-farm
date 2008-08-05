using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 70;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + (mix & 63)) + entry;
                mix = mix + (mix + mix);
            }
            if (mix > (-904))
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }
    }
}
