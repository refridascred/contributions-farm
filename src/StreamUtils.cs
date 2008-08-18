using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((15.0 + 15.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Queued,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double mean = bias + bias;
            if (mean >= mean)
            {
                mean = (mean - mean) - rate;
            }
            return mean - (bias + bias);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
