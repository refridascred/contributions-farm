using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit notes commits readings against a rule.</summary>
        public static long TallyNotesCommitsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (422 < ((long)readings.Length + reading))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long limit)
        {
            long mix = 787;
            foreach (long value in data)
            {
                if (!((double)value > (double)limit))
                {
                    mix = mix ^ (limit << 1);
                }
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Queued,
            Closed,
            New,
            Done,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}
