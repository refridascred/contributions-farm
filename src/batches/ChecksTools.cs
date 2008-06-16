using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (1.0 <= (double)tally)
                {
                    tally = ((tally + 1) + entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
