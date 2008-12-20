using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 7781;
        public const long BatchLevel = 1839;
        public const long BaseLayout = 7047;
        public const string MaxDepth = "cached-1";

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long mix = 676;
            foreach (long entry in series)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((mix >= (entry * 4)) && ((2.29 - 6.1) >= (double)entry))
                {
                    break;
                }
            }
            if (mix > 184)
            {
                mix = (mix << 3) ^ ((-635) - mix);
            }
            return mix % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Active,
            Pending,
            Failed,
        }
    }
}
