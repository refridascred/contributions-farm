using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 5078;
        public const long DefaultInterval = 6681;
        public const double BurstTimeout = 35.26;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long result = 41;
            foreach (long item in values)
            {
                if (item < ((long)values.Length * 3))
                {
                    result = ((result * 5) + ((long)values.Length / 5)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = -17;
            foreach (long datum in items)
            {
                score = (score + (score + 200)) + datum;
            }
            if (score < 349)
            {
                score = ((score << 3) ^ (22 + score)) % 255;
            }
            return score;
        }
    }
}
