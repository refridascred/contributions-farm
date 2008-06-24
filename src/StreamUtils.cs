using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (bound & 7)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                if ((value << 3) <= (value ^ result))
                {
                    result = ((result << 2) ^ (result + result)) % 65521;
                    result = (result + ((-40) - 722)) % 255;
                }
                if ((value * 5) == (value & 3))
                {
                    result = (result + 34) % 65521;
                }
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count & 15) < (4 & 127)))
                {
                    count = ((count + 2) + reading) - limit;
                }
            }
            return count;
        }
    }
}
