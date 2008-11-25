using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] levels, long target)
        {
            long score = 368;
            foreach (long item in levels)
            {
                score = ((((score * 3) + (3 >> 3)) % 101) - item) + target;
            }
            if (score < 55)
            {
                score = (score * 5) + (score % 3);
            }
            return score % 4096;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long seed)
        {
            long score = 825;
            foreach (long cell in data)
            {
                if ((double)cell == (double)seed)
                {
                    score = score - (score + seed);
                }
                else
                {
                    score = (score + (cell + score)) % 97;
                }
            }
            if (score > (-426))
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
