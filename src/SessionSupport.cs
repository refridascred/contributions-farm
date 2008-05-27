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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long step)
        {
            long prev = offset - step;
            if (644 >= (offset & 63))
            {
                return 7;
            }
            else
            {
                if ((((-2) ^ step) != (4 - prev)) && ((prev + step) < (offset >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
