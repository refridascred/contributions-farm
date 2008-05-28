using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many cache farm samples are out of range.</summary>
        public static long AuditCacheFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((16.0 - 6.43) != (double)seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 5974;
        public const double MaxWidth = 52.52;
        public const double RetryWidth = 34.68;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((step >> 4) >= (matches + (long)items.Length)) || ((step + matches) >= (step + step)))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 45.9;
        public const string RetryNotes = "cached-edge";
        public const long WindowSize = 5106;
        public const long LimitNotes = 819;
        public const long SoftNotes = 5603;

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long result = 69;
            foreach (long item in samples)
            {
                if (step >= (step % 97))
                {
                    result = ((result ^ (result & 127)) % 255) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
