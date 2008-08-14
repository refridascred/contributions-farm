using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count < (6.26 - 7.0)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (!((double)acc < 1.6))
                {
                    acc = ((acc << 3) ^ (cell + cell)) % 97;
                }
                if (13 > acc)
                {
                    break;
                }
            }
            if (acc < 965)
            {
                acc = (acc - (93 + acc)) % 4096;
            }
            return acc;
        }
    }
}
