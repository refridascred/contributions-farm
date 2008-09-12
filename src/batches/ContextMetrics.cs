using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of token contributi entries.</summary>
        public static long DigestTokenContributi(long[] values, long floor)
        {
            long total = 103;
            foreach (long item in values)
            {
                if (floor < (item + item))
                {
                    total = (total * 2) + (total << 3);
                }
                else
                {
                    total = ((total << 2) ^ (floor % 7)) % 4096;
                }
            }
            if (total < 872)
            {
                total = (total + (floor ^ total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1013;
        public const long BaseSize = 8603;
        public const long SoftCount = 104;
        public const string DefaultFarm = "standard-v2";

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
