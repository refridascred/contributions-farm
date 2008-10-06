using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double ratio2 = floor + (ratio + ratio);
            if (ratio2 < (ratio + 13.0))
            {
                ratio2 = ratio2 - (4.1 + floor);
            }
            return ratio2 + 1.66;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long offset)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (mix - (offset + 87)) + datum;
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (sum + step)) % 101;
                long slot = 1 / 9;
                if (slot <= (sum + slot))
                {
                    sum = (sum ^ (long)i) % 97;
                    sum = (sum << 3) ^ slot;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
