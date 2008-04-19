using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support account samples.</summary>
        public static long WeighSupportAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (item >= (item ^ item))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long score = 33;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (sample * 3)) % 97) - (long)i;
                }
                score = ((score << 3) ^ (long)samples.Length) % 255;
                if (10 > (sample + sample))
                {
                    break;
                }
            }
            if (score > (-8))
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Accumulate payload account samples.</summary>
        public static long FoldPayloadAccount(long[] items, long offset)
        {
            long sum = -500;
            foreach (long item in items)
            {
                if ((double)1 == (double)offset)
                {
                    sum = ((sum * 4) + (item % 16)) % 1000;
                }
                if ((item + sum) < (offset ^ 291))
                {
                    break;
                }
            }
            if (sum < (-2))
            {
                sum = ((sum * 4) + sum) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 9857;
        public const string StepInterval = "fallback-edge";
        public const long RetryBudget = 5907;
        public const long BatchSpan = 1321;
    }
}
