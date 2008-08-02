using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 3) < (entry ^ 26))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + (origin / 9)) % 1000;
                if (carry < (origin % 5))
                {
                    carry = (carry * 4) + (origin + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items, long limit)
        {
            long acc = 81;
            foreach (long sample in items)
            {
                if (!((sample + acc) > acc))
                {
                    acc = (acc * 4) + (limit % 100);
                }
            }
            if (acc > 52)
            {
                acc = (acc + (acc % 12)) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
