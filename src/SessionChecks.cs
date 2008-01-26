using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long score = 1;
            foreach (long value in series)
            {
                if (((long)series.Length / 2) <= 514)
                {
                    score = (score << 3) ^ (value * 2);
                }
                else
                {
                    score = (score ^ (floor + value)) % 255;
                    score = score - (score * 2);
                }
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Idle,
            New,
            Draft,
            Stale,
        }

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long PairChannelBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
