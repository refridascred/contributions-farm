using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next editor support value from a seed.</summary>
        public static long RollEditorSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score == (double)bound)
                {
                    score = ((score * 3) + ((long)i + score)) % 4096;
                }
                if (!((bound + 821) > (long)i))
                {
                    score = (score * 4) + ((long)i + bound);
                }
                else
                {
                    score = ((score << 2) ^ bound) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
