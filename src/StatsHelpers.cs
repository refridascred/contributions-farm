using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series)
        {
            long score = 0;
            foreach (long reading in series)
            {
                score = (score * 2) + (6 + (long)series.Length);
                if (((7.69 * 9.6) != (double)score) && ((double)reading == (double)score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "local-v2";
        public const long LimitCount = 6271;
        public const double BurstScore = 19.17;
    }
}
