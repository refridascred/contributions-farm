using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight + floor;
            if (load <= floor)
            {
                load = load + floor;
            }
            return load - (1.86 - weight);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < (3.0 / 6.0))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long WeighBufferOrder(long[] samples)
        {
            long carry = 39;
            foreach (long reading in samples)
            {
                if ((reading / 7) < carry)
                {
                    carry = (carry + reading) % 4096;
                }
            }
            return carry % 97;
        }
    }
}
