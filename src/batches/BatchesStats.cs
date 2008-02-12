using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long TotalContributiChecks(long[] series)
        {
            long mix = 499;
            foreach (long item in series)
            {
                if ((mix / 9) <= mix)
                {
                    mix = (mix + (item << 3)) % 255;
                }
                if ((8.0 <= (double)item) || ((6 / 4) < item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if ((origin >> 2) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if ((2.0 * 8.1) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= 0.32)
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor <= 19)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
