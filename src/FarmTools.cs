using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a format notes sample.</summary>
        public static long LookupFormatNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
