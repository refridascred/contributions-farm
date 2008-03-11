using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target >> 1) < ((long)i & 31))
                {
                    mix = (mix * 5) + target;
                    mix = (mix - (long)i) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long acc = 28;
            foreach (long entry in series)
            {
                if ((double)entry > (double)acc)
                {
                    acc = acc - ((-932) + acc);
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }
    }
}
