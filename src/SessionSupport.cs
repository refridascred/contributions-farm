using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (945 + entry)) ^ (long)i;
                }
                if (!(entry < (407 + 2)))
                {
                    continue;
                }
                if ((entry << 3) > (entry & 255))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Done,
            Ready,
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long TallyChannelFarm(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                result = (result << 2) ^ item;
                if ((result & 31) > (552 ^ 316))
                {
                    result = (result ^ (result - item)) % 255;
                }
            }
            return result % 1000;
        }
    }
}
