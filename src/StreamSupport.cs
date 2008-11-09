using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 976;
            foreach (long entry in readings)
            {
                if ((entry << 3) <= (entry + score))
                {
                    score = (score - (score << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Match up githubfarm profile samples.</summary>
        public static long PairGithubfarmProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
