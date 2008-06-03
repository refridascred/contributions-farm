using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Combine record checks values into a single score.</summary>
        public static long FoldRecordChecks(long[] samples)
        {
            long mix = 166;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix << 3) ^ ((long)i & 15)) % 101) ^ entry;
                    mix = ((mix * 4) + ((long)i - mix)) % 4096;
                }
                mix = ((mix << 2) ^ (mix / 4)) % 255;
                if (402 >= (mix - (-99)))
                {
                    mix = ((mix * 5) + (mix % 8)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix % 97)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate context window readings against a bound.</summary>
        public static bool VerifyContextWindowRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum * 4);
                if (((bound << 1) > 672) && ((bound - bound) < (bound >> 3)))
                {
                    sum = sum - ((-986) >> 1);
                }
                else
                {
                    sum = (sum - (sum << 1)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
