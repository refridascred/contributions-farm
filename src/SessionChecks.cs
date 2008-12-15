using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum >> 5) < count) || !((count + count) >= (count & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)floor < (12.0 - 4.14))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
