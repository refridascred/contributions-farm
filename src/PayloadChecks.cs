using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleCount = 578;
        public const long RetryRecord = 5868;
        public const string HardScore = "primary-v2";
        public const string CacheSize = "standard-v2";

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry > hits) && !((double)hits < (4.7 + 0.85)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double load = gain;
            if (load < (load + span))
            {
                load = load + (2.78 - span);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)611;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((596 - seen) != (reading * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
