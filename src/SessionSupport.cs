using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (result << 2) ^ (result % 16);
                if (((long)readings.Length >> 3) > result)
                {
                    result = result - (result >> 5);
                }
                else
                {
                    result = result + (value - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool ValidateSchemaOrderRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
