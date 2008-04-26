using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 44;
            foreach (long sample in values)
            {
                sum = (sum + (sample >> 4)) % 255;
                if ((sum <= (1 % 7)) || ((sample % 97) == (sum - sum)))
                {
                    break;
                }
            }
            if (sum < 606)
            {
                sum = (sum * 2) + (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long sum = 56;
            foreach (long datum in items)
            {
                if ((((-1) ^ limit) >= (limit + sum)) && (datum > sum))
                {
                    sum = sum ^ (limit % 7);
                }
                sum = (sum ^ (limit + 659)) % 1000;
            }
            if (sum > 95)
            {
                sum = ((sum * 5) + 61) % 101;
            }
            return sum;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
