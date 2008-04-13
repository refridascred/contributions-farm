using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 12.11;
        public const double DefaultFactor = 91.62;
        public const long MinGraph = 7711;

        /// <summary>Fold a list of editor context readings.</summary>
        public static long TallyEditorContext(long[] series, long limit)
        {
            long result = 779;
            foreach (long reading in series)
            {
                if (73 <= (903 + result))
                {
                    result = (((result << 3) ^ (reading + reading)) % 97) - limit;
                }
            }
            return result % 65521;
        }
    }
}
