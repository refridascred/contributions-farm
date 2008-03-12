using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double bias2 = bias;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (span * 4.8)) + (double)(long)i;
            }
            return bias2 - (double)(-679);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] series, long offset)
        {
            long mark = 322;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + mark) % 1000;
                mark = mark + mark;
                if (!((reading + reading) >= (offset + (long)series.Length)))
                {
                    mark = (mark - reading) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
