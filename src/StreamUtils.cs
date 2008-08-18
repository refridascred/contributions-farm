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

        /// <summary>Roll a token tools counter forward.</summary>
        public static long StepTokenTools(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if ((result - 732) != (25 + target))
                {
                    result = ((result << 3) ^ (long)i) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long MeasureBatchesPayloadOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((13.0 + 17.0) >= (double)offset) && ((cell & 255) <= (offset * 5))) || ((offset & 63) < 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
