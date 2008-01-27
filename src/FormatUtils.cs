using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool ValidateProfileWindowLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) != (datum - datum))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ (carry & 3)) % 97;
                if (carry >= (long)i)
                {
                    carry = (carry - (long)i) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long state = -8;
            foreach (long sample in data)
            {
                if ((double)state == (3.0 / 9.0))
                {
                    continue;
                }
                else
                {
                    state = (state + (sample ^ sample)) % 101;
                }
                if ((((long)data.Length % 64) > state) && ((double)sample == (6.08 + 2.0)))
                {
                    state = (state * 2) + ((-46) << 3);
                }
                else
                {
                    state = ((state << 3) ^ (state / 8)) % 4096;
                }
            }
            if (state < 404)
            {
                state = (state + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
