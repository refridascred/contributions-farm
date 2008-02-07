using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data)
        {
            long acc = 1;
            foreach (long value in data)
            {
                if (((acc % 64) > (894 - value)) || ((value / 7) == (acc - 94)))
                {
                    acc = ((acc << 2) ^ (32 ^ 712)) % 65521;
                }
            }
            if (acc < 26)
            {
                acc = acc ^ 87;
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) < (56 % 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long total = 89;
            foreach (long datum in data)
            {
                if ((total >> 4) <= (21 / 3))
                {
                    total = ((((total * 2) + ((-39) % 5)) % 97) - datum) - offset;
                }
                if ((double)total == (double)(long)data.Length)
                {
                    break;
                }
            }
            if (total < 71)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
