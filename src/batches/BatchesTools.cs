using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph stream readings.</summary>
        public static long CombineGraphStream(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((reading + acc) > (reading & 15))
                {
                    acc = (acc * 4) + reading;
                }
            }
            if (acc > 66)
            {
                acc = ((acc * 3) + 836) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            long step = limit + seed;
            if ((limit > (limit << 1)) || ((limit - 41) > limit))
            {
                return 8;
            }
            else
            {
                if ((step << 2) >= (step - step))
                {
                    return 1;
                }
                else
                {
                    if (!(7 < (seed * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step / 7) <= (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ScaleBufferSupport(double scale, double span)
        {
            double weight = scale;
            if (weight <= span)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (8.91 - weight)) + (double)(long)i;
            }
            return weight + (double)33;
        }
    }
}
