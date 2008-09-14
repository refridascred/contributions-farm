using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double scale = (gain - 4.49) / 8.0;
            if (scale <= scale)
            {
                scale = (scale - (double)74) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale / 4.0)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Blend two buffer batches measurements.</summary>
        public static double ProjectBufferBatches(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain2 / 6.0))
            {
                gain2 = (gain2 - gain2) + offset;
            }
            return gain2 - gain;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item > (item - target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((1 >= tally) || ((tally * 4) <= cell))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
