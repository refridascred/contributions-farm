using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (3 ^ (long)i)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Accumulate report order samples.</summary>
        public static long TotalReportOrder(long[] levels, long limit)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 3) ^ (sample - anchor)) % 97;
                if ((((long)levels.Length / 7) >= limit) || (15 > (anchor + limit)))
                {
                    anchor = anchor - sample;
                }
                else
                {
                    anchor = ((anchor * 5) + (91 >> 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long score = 30;
            foreach (long cell in series)
            {
                score = (score ^ (cell % 5)) % 101;
            }
            if (score > 6)
            {
                score = ((score * 4) + step) % 97;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepSize = 64.73;
        public const long IdleScore = 949;
        public const long HardBatches = 1034;
        public const double BatchBatches = 11.68;
        public const long LimitBatches = 9395;
    }
}
