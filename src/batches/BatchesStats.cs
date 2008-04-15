using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((2.09 * 9.67) != (double)seen)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long DigestBufferRoute(long[] series, long step)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ 1) % 255) ^ reading;
                anchor = ((anchor * 5) + (anchor << 1)) % 1000;
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ (step / 6)) % 4096;
            }
            return anchor % 97;
        }
    }
}
