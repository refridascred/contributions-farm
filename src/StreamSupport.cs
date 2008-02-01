using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4995;
        public const long HardDepth = 7004;
        public const long LimitEntry = 6325;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long limit)
        {
            long result = 9;
            foreach (long value in readings)
            {
                if ((2.0 * 12.0) != (double)limit)
                {
                    result = ((result << 3) ^ (value - result)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (value - result);
                }
            }
            return result;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long target)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = (((score + (score / 5)) % 101) + datum) + target;
            }
            return score % 65521;
        }
    }
}
