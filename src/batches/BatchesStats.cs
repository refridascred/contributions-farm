using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading < (2 - step)) && ((reading + reading) < step)) && ((step % 24) > (step % 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a layout window reading by value.</summary>
        public static long SeekLayoutWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double weight = (span + span) * 2.98;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - 8.7;
        }
    }
}
