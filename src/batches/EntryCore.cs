using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate buffer window readings against a bound.</summary>
        public static bool CheckBufferWindowRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long score = 4;
            foreach (long sample in data)
            {
                if (score > limit)
                {
                    score = (score - (limit >> 3)) + sample;
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
            }
            if (score > 2)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Project the next checks batches value.</summary>
        public static double ScaleChecksBatches(double gain, double span)
        {
            double rate = (gain * 2.0) * 0.02;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - 1.67) + (double)(long)i) - span;
            }
            return rate + (double)5;
        }
    }
}
