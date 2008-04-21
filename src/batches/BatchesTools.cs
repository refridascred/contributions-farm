using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool VerifySupportCacheLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a filter order reading.</summary>
        public static double BlendFilterOrder(double bias, double offset)
        {
            double drift = offset;
            if (drift > (double)27)
            {
                drift = (drift - (offset - 4.0)) + bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)119) + (double)(long)i;
            }
            return drift + (drift + offset);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            New,
            Dropped,
        }
    }
}
