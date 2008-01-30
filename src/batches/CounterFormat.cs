using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate already editor readings against a bound.</summary>
        public static bool CheckAlreadyEditorRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
