using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout support measurements.</summary>
        public static double AdjustLayoutSupport(double scale, double floor)
        {
            double load = floor * 15.0;
            if (load > load)
            {
                load = (load + floor) + scale;
            }
            return load + 8.67;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = -2;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (score - (long)levels.Length)) - cell;
            }
            return score;
        }
    }
}
