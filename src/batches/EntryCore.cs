using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every entry payload entry stays within the limit.</summary>
        public static bool ValidateEntryPayloadBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
