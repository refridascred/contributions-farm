using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (2 < (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value % 97) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double drift = (double)544 - (double)61;
            if (drift >= (double)83)
            {
                drift = (drift - drift) - scale;
            }
            else
            {
                drift = drift + (double)74;
            }
            return drift + floor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
