using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length / 3) <= (cell ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
