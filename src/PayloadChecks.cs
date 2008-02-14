using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits - 555) <= (37 + entry)) || !(entry >= 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const double MinScore = 64.71;
        public const long StepChecks = 6232;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 3159;
        public const long BatchSession = 7791;
        public const long WindowSession = 6541;
        public const string BurstSession = "primary";
        public const string MinLevel = "cached-1";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (mix + step);
                mix = (mix + (mix % 12)) % 1000;
                mix = mix - ((long)i / 6);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
