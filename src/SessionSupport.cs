using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next route tools value.</summary>
        public static double ScaleRouteTools(double rate, double bias)
        {
            double bias2 = 9.99;
            if (bias2 < bias)
            {
                bias2 = (bias2 + (double)8) + rate;
            }
            return bias2 + bias;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long state = -68;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (datum + step)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if ((double)mark < 5.4)
                {
                    mark = (mark - value) % 4096;
                }
            }
            if (mark > 990)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
        }
    }
}
