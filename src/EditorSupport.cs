using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double drift = weight;
            if (drift <= (weight / 3.0))
            {
                drift = (drift + drift) - span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (18.0 + drift)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine commits entry values into a single score.</summary>
        public static long CombineCommitsEntry(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                carry = ((carry - 3) % 1000) ^ sample;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Dropped,
            Pending,
        }
    }
}
