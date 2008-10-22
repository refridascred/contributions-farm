using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long seed)
        {
            long score = 88;
            foreach (long cell in series)
            {
                if (!((cell - seed) > (seed + score)))
                {
                    score = (score + (score << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count token support pairs that satisfy a relation.</summary>
        public static long OverlapTokenSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
