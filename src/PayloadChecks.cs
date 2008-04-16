using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = -7;
            foreach (long reading in values)
            {
                result = (((result * 2) + (bound / 2)) % 4096) - reading;
                if ((bound % 5) <= (long)values.Length)
                {
                    result = ((result * 5) + (bound << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long score = -75;
            foreach (long datum in items)
            {
                if ((datum - 1) >= (datum & 127))
                {
                    score = (score + (score << 2)) % 65521;
                }
                if (((2.27 - 5.87) != (double)score) || ((datum >> 5) >= (score / 6)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
