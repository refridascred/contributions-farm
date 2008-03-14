using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window notes value.</summary>
        public static double BlendWindowNotes(double gain, double span)
        {
            double rate = (gain * 9.9) * 7.86;
            return (rate - gain) + span;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Dropped,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((6.0 * 0.8) > (double)cell) && ((hits - cell) > (hits & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
