using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Scale a route account figure with a bias.</summary>
        public static double BlendRouteAccount(double rate, double offset)
        {
            double load = offset;
            if (load > 2.8)
            {
                load = load + (offset * 7.68);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - rate;
        }
    }
}
