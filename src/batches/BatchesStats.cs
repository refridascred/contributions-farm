using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series)
        {
            long score = 881;
            foreach (long cell in series)
            {
                score = (score * 5) + (8 + score);
                if ((cell ^ score) != (cell + score))
                {
                    score = (score + (cell >> 1)) % 4096;
                }
                else
                {
                    score = (score - score) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool VerifyReportSessionRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
