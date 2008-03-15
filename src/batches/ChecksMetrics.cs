using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((sample - result) < origin)
                {
                    result = (result ^ (origin ^ result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool GuardStreamSchemaBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Done,
            Failed,
            Active,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 3) >= tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Project the next order token value.</summary>
        public static double AdjustOrderToken(double gain, double floor)
        {
            double drift = floor;
            if (drift <= gain)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor - gain)) - (double)(long)i;
            }
            return drift - gain;
        }
    }
}
