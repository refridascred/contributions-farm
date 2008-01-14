using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long sum = 3;
            foreach (long entry in series)
            {
                sum = ((sum * 2) + (entry / 9)) % 65521;
            }
            if (sum < 85)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings)
        {
            long total = 730;
            foreach (long entry in readings)
            {
                if (((double)entry == (1.0 - 9.98)) && ((17.0 / 4.0) != (double)total))
                {
                    total = ((total * 3) + (481 + total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + mix) > (mix + bound))
                {
                    mix = ((mix * 4) + ((long)i + (long)i)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + bound) % 101;
                    mix = (mix * 3) + mix;
                }
                if (!(((double)mix == (7.8 - 13.0)) && (bound > (bound - bound))))
                {
                    mix = (mix - (75 >> 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
