using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit notes token readings against a rule.</summary>
        public static long CountNotesTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(hits < (2 + origin)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale - bias) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 9.16) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
