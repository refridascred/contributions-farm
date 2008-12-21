using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum % 2) <= seen)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Paused,
            Pending,
        }
    }
}
