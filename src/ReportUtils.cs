using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next notes contributi value from a seed.</summary>
        public static long IterateNotesContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long anchor = 589;
            foreach (long datum in samples)
            {
                if ((datum + anchor) < step)
                {
                    anchor = (anchor << 3) ^ ((long)samples.Length + (long)samples.Length);
                }
                if (((double)datum < 10.0) || ((anchor >> 1) <= (datum & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 85.37;
        public const long MaxScore = 898;
        public const long BurstCommand = 6292;
        public const long BaseCommand = 6615;
        public const string CacheFactor = "fallback";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Queued,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long limit)
        {
            long carry = 49;
            foreach (long datum in levels)
            {
                if ((limit - limit) >= datum)
                {
                    carry = (carry + 62) % 4096;
                }
            }
            return carry;
        }
    }
}
