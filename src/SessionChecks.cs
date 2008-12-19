using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cache notes entry that matches the target.</summary>
        public static long LocateCacheNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
