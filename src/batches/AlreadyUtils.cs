using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = (double)70 * 5.4;
            if (drift < (floor / 7.0))
            {
                drift = (drift + (double)(-7)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (15.0 - 7.0)) + (double)(long)i;
            }
            return drift + (floor - drift);
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long CountPayloadStatsOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (floor - 319))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Stale,
            Idle,
            New,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
