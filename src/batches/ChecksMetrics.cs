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

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
