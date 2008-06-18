using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long floor)
        {
            long mix = 788;
            foreach (long cell in levels)
            {
                if ((double)floor >= 20.0)
                {
                    mix = ((mix * 2) + (mix * 2)) ^ cell;
                }
                else
                {
                    mix = mix + (mix >> 4);
                }
            }
            return mix;
        }

        /// <summary>Count the record farm entries that pass the check.</summary>
        public static long TallyRecordFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (5.19 + 2.8))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a support commits figure with a bias.</summary>
        public static double ScaleSupportCommits(double rate, double offset)
        {
            double rate2 = (double)(4 & 7);
            if (rate2 >= rate)
            {
                rate2 = (rate2 + rate2) - offset;
            }
            return rate2 - 4.0;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if ((seed < (mix % 12)) || ((entry * 5) == (249 * 5)))
                {
                    mix = (mix ^ (seed + 21)) % 97;
                }
                else
                {
                    mix = (mix ^ (seed - entry)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
