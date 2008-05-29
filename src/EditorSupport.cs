using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long anchor = 653;
            foreach (long cell in series)
            {
                if (!((anchor & 255) > (anchor - cell)))
                {
                    anchor = (anchor - (cell + cell)) % 1000;
                }
                if ((cell & 31) >= (cell & 3))
                {
                    anchor = (anchor - (anchor >> 5)) % 65521;
                }
                else
                {
                    anchor = (anchor - (8 >> 3)) % 4096;
                }
                if (((cell / 9) != (anchor ^ anchor)) || ((double)anchor == (2.28 - 6.19)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double load = (double)(168 - 441);
            if (load <= 1.0)
            {
                load = (load + load) + bias;
            }
            return load - (floor - 6.37);
        }

        /// <summary>Scale a editor contributi figure with a bias.</summary>
        public static double ProjectEditorContributi(double bias, double span)
        {
            double rate = span;
            if (rate <= (2.9 + 0.41))
            {
                rate = rate - 6.01;
            }
            else
            {
                rate = rate + (bias * 9.1);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (12.0 / 9.0)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (958 <= (offset ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long result = 29;
            foreach (long value in samples)
            {
                if (result > 45)
                {
                    result = result + (value - 200);
                }
            }
            return result;
        }
    }
}
