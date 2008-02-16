using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((-8) + entry) > 13)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long result = -941;
            foreach (long reading in levels)
            {
                result = (result * 3) + (result - reading);
            }
            return result % 1000;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Closed,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
