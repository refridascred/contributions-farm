using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = (double)(14 + 841);
            if (bias2 <= (7.81 / 5.0))
            {
                bias2 = ((bias2 - bias2) - rate) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (19.0 + 2.9)) + (double)(long)i;
            }
            return bias2 - (double)58;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Queued,
            Failed,
            New,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                if ((score + item) > (score + (-699)))
                {
                    score = ((score * 3) + (long)items.Length) % 101;
                }
                else
                {
                    score = (score * 2) + (score << 3);
                }
            }
            if (score < 93)
            {
                score = (score ^ (score >> 1)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
