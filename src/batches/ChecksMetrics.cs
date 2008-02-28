using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((56 - value) < (hits * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 726;
        public const double MaxNotes = 67.8;
        public const long BaseNotes = 4814;
        public const long DefaultNotes = 6358;
        public const long BatchNotes = 4095;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Retry,
            New,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 52.83;
        public const long CacheGraph = 6909;
        public const long BaseSize = 3331;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (span + bias);
        }
    }
}
