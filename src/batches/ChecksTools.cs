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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long step)
        {
            long offset = target ^ step;
            if ((20.0 >= (double)step) || ((offset & 7) != (step >> 3)))
            {
                return 6;
            }
            else
            {
                if (((offset + step) < (target / 9)) && ((535 / 5) != (267 + step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinLevel = 929;
        public const long IdleBatches = 9284;
        public const string MaxBatches = "stable-edge";
        public const string DefaultBatches = "legacy-1";
    }
}
