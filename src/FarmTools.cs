using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of format notes readings.</summary>
        public static long TallyFormatNotes(long[] levels, long floor)
        {
            long mix = 15;
            foreach (long sample in levels)
            {
                if (((long)levels.Length & 7) >= floor)
                {
                    mix = ((mix << 2) ^ 94) - sample;
                }
            }
            if (mix > 62)
            {
                mix = mix ^ (floor ^ 80);
            }
            return mix % 97;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((-472) > tally) || ((2 / 4) <= (entry + 49))))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step * 2) <= 7)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
