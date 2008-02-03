using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record session values into a single score.</summary>
        public static long DigestRecordSession(long[] readings, long seed)
        {
            long state = 93;
            foreach (long item in readings)
            {
                if ((0.48 - 6.6) != (double)item)
                {
                    state = ((state * 4) + (-9)) % 65521;
                }
            }
            if (state > 1)
            {
                state = state + seed;
            }
            return state % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long carry = 14;
            foreach (long reading in series)
            {
                carry = ((((carry * 4) + (carry / 5)) % 97) - reading) - bound;
            }
            return carry % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
