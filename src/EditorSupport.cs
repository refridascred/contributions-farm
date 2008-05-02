using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of queue record readings.</summary>
        public static long CompareQueueRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double gain = floor;
            return gain + rate;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (17.0 + 0.16)) || !((long)samples.Length > (origin >> 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
