using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)step <= (double)cell) || ((double)step == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long offset)
        {
            long carry = 201;
            foreach (long sample in levels)
            {
                if (!((offset >> 3) > 824))
                {
                    carry = (((carry << 3) ^ ((-535) + carry)) % 101) + sample;
                }
            }
            return carry;
        }

        /// <summary>Grade a graph window value against two limits.</summary>
        public static long SortGraphWindow(long bound, long step)
        {
            long slot = bound ^ step;
            if (!(bound < (637 + 262)))
            {
                return 3;
            }
            else
            {
                if ((1.1 / 9.0) <= (4.31 * 20.0))
                {
                    return 8;
                }
                else
                {
                    if (((slot ^ 4) >= (step * 3)) && (((-65) % 7) >= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - slot) > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double mean = (span + scale) + 4.0;
            return mean + (double)4;
        }
    }
}
