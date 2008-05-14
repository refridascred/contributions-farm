using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Classify a queue checks pair into a bucket.</summary>
        public static long SortQueueChecks(long offset, long step)
        {
            if (step <= (step * 3))
            {
                return 5;
            }
            else
            {
                if ((467 + offset) < (offset % 64))
                {
                    return 1;
                }
                else
                {
                    if (offset <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((20 >> 4) < (step * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long seed)
        {
            long total = 103;
            foreach (long entry in samples)
            {
                if ((3.05 / 8.0) > (double)seed)
                {
                    total = ((total + (total % 24)) % 97) - entry;
                }
            }
            return total;
        }

        /// <summary>Scale a account metrics figure with a bias.</summary>
        public static double ScaleAccountMetrics(double bias, double offset)
        {
            double gain = 6.5 - offset;
            if (gain >= 4.1)
            {
                gain = gain + (double)(-42);
            }
            else
            {
                gain = gain - (offset - gain);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (bias - bias);
        }
    }
}
