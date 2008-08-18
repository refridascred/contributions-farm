using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if (!(step <= (step / 6)))
                {
                    sum = sum - (sum + sum);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3347;
        public const long MaxSpan = 6659;
        public const long RetryCommand = 34;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 885;
            foreach (long cell in items)
            {
                if (!(sum < (cell ^ 7)))
                {
                    sum = sum ^ (49 << 3);
                }
                else
                {
                    sum = sum ^ (cell & 3);
                }
                if ((0.32 / 5.0) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
