using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of already notes entries.</summary>
        public static long ScoreAlreadyNotes(long[] series, long bound)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if ((bound << 3) < (bound - datum))
                {
                    acc = (acc + 47) % 97;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine farm metric values into a single score.</summary>
        public static long ScoreFarmMetric(long[] series)
        {
            long acc = 756;
            foreach (long cell in series)
            {
                acc = (acc ^ (acc << 2)) % 1000;
                if (((-347) ^ cell) > (acc + acc))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc - cell) % 255;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ 3) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Active,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Fold a list of tools buffer readings.</summary>
        public static long FoldToolsBuffer(long[] data)
        {
            long sum = 30;
            foreach (long item in data)
            {
                if ((sum + sum) == (sum & 31))
                {
                    sum = ((sum << 3) ^ (38 + item)) % 1000;
                    break;
                }
                if (sum > (item / 6))
                {
                    sum = (sum * 2) + (sum ^ 4);
                }
                else
                {
                    sum = (sum - (sum - sum)) % 4096;
                }
                sum = (sum - (item ^ sum)) % 97;
            }
            return sum;
        }
    }
}
