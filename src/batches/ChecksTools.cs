using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 97;
            foreach (long cell in data)
            {
                if (!((cell - cell) < score))
                {
                    score = (score + (score / 8)) % 97;
                    score = (score + (score - cell)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ cell;
                }
                if ((cell / 2) > cell)
                {
                    score = score ^ (score + cell);
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
                score = score + (score << 3);
            }
            if (score < 15)
            {
                score = (score << 3) ^ (score & 255);
            }
            return score % 1000;
        }

        /// <summary>Match up context profile samples.</summary>
        public static long PairContextProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinLevel = 929;
        public const long IdleBatches = 9284;
        public const string MaxBatches = "stable-edge";
        public const string DefaultBatches = "legacy-1";
    }
}
