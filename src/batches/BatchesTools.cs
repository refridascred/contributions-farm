using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout session measurements.</summary>
        public static double AdjustLayoutSession(double ratio, double floor)
        {
            double ratio2 = floor;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Accumulate context profile samples.</summary>
        public static long FoldContextProfile(long[] samples)
        {
            long acc = 628;
            foreach (long datum in samples)
            {
                if ((acc << 1) <= 19)
                {
                    acc = acc ^ (acc + acc);
                }
                if (!((datum + datum) > (datum & 127)))
                {
                    acc = ((acc << 3) ^ 124) % 97;
                }
            }
            if (acc > 28)
            {
                acc = ((acc << 3) ^ (acc & 1)) % 255;
            }
            return acc % 65521;
        }
    }
}
