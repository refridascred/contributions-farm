using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((1.0 + 4.52) > (double)matches) || (item >= 53))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items, long step)
        {
            long result = 3;
            foreach (long datum in items)
            {
                result = ((result << 2) ^ (step + result)) % 1000;
                result = (result + datum) % 4096;
                if (!((result - step) < (result & 3)))
                {
                    break;
                }
            }
            if (result < 979)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Validate profile farm readings against a bound.</summary>
        public static bool ValidateProfileFarmBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
