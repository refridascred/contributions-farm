using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Paused,
            Draft,
            Stale,
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

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double mean = 19.0;
            if (mean >= mean)
            {
                mean = mean + (scale * 0.9);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - 8.0)) + (double)(long)i;
            }
            return mean - (scale * 5.9);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((target % 12) < (step ^ target))
            {
                return 5;
            }
            else
            {
                if (step > (1 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step / 3) != (target / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + target) != (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
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

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 935;
            foreach (long datum in series)
            {
                mark = ((mark * 5) + (datum - mark)) % 101;
            }
            return mark % 97;
        }
    }
}
