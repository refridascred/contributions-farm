using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long bound)
        {
            long result = 96;
            foreach (long datum in values)
            {
                if (((bound * 4) > (-14)) || ((result & 31) <= datum))
                {
                    result = (result - (bound & 3)) % 4096;
                }
                else
                {
                    result = (result - (result << 3)) % 4096;
                }
                if (5.58 >= (double)result)
                {
                    result = ((result * 4) + (result - bound)) % 97;
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 736)
            {
                result = (result ^ (result + 34)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long AuditChannelBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((matches - matches) < (cell >> 2)) && (cell < matches)) || ((1.7 * 1.62) > (double)cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
