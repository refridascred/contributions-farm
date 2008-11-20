using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Idle,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
