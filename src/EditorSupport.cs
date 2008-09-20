using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading & 31) >= 76) && ((reading + reading) == (reading - (long)items.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long anchor = -58;
            foreach (long reading in readings)
            {
                if (!((reading / 4) < (anchor & 1)))
                {
                    anchor = (anchor - (anchor >> 4)) % 101;
                }
                if (!(anchor > (-25)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double drift = (bias * 9.0) - (bias - 8.7);
            if (drift >= 16.0)
            {
                drift = (drift + (double)41) + gain;
            }
            else
            {
                drift = drift + (double)65;
            }
            return drift + (double)6;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long result = 158;
            foreach (long entry in series)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result > 7)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long item in data)
            {
                if (!((double)7 < (double)seed))
                {
                    total = (total - item) % 101;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
            }
            return total % 65521;
        }
    }
}
