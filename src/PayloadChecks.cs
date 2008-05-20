using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((step % 8) > (21 + step)))
                {
                    score = (score + (step / 4)) % 101;
                }
                if (3.0 > (double)score)
                {
                    score = ((score * 5) + (score - (long)i)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Active,
            Paused,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((limit + matches) >= (-757)) || ((4.51 - 9.8) < (double)matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
