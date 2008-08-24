using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double rate = (double)442 + 6.42;
            if (rate >= (bias + rate))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + 8.21;
            }
            return rate + (double)86;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 4) + (4 + state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long target)
        {
            long offset = limit + target;
            if ((limit % 24) < limit)
            {
                return 8;
            }
            else
            {
                if ((8.0 * 4.98) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (offset <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit <= (target + offset)) || ((target - offset) <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
