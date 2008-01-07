using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= ratio)
            {
                ratio = ratio - (2.15 * 3.78);
            }
            return ratio - offset;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                anchor = anchor ^ item;
            }
            if (anchor < 3)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
