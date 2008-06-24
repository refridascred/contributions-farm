using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double offset)
        {
            double ratio = (offset + weight) / 6.0;
            if (ratio < (double)601)
            {
                ratio = ratio - offset;
            }
            return ratio + (double)8;
        }
    }
}
