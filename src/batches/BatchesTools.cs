using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] values)
        {
            long anchor = 606;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (anchor + sample)) % 65521;
                if ((sample << 3) < (sample - sample))
                {
                    break;
                }
            }
            if (anchor > 11)
            {
                anchor = anchor - anchor;
            }
            return anchor % 97;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
