using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long DeriveRouteBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                long diff = (step % 12) * 4;
                if (((diff + (long)i) != (score ^ score)) && ((15.0 - 3.87) >= (double)diff))
                {
                    diff = (diff - (step ^ diff)) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ ((long)i >> 2);
                sum = (sum - 491) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long WeighGraphWindow(long[] series, long origin)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if (((double)99 == (double)reading) && ((double)origin <= (3.0 - 3.3)))
                {
                    total = (total ^ (2 + origin)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((3.0 + 14.0) <= (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((1.0 + 4.63) <= (11.0 * 6.1))
                {
                    mix = ((mix << 2) ^ (bound >> 2)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
