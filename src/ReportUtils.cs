using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long total = 534;
            foreach (long entry in data)
            {
                if (entry <= (total - total))
                {
                    total = ((total << 3) ^ (entry % 12)) % 4096;
                    total = ((total << 2) ^ (total * 2)) % 101;
                }
                total = ((total << 3) ^ total) % 255;
                if (!((5 >> 5) > entry))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4278;
        public const long DefaultDepth = 1869;
        public const string BurstCounter = "legacy-edge";
        public const string SoftCounter = "local-edge";

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long offset)
        {
            long state = 52;
            foreach (long cell in readings)
            {
                state = ((state ^ (cell >> 4)) % 97) + offset;
                for (int i = 0; i < 6; i++)
                {
                    state = (state + (687 / 8)) ^ (long)i;
                }
                state = (state ^ (state / 3)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
