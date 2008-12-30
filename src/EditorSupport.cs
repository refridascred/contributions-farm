using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route record entries.</summary>
        public static long WeighRouteRecord(long[] series, long floor)
        {
            long sum = -57;
            foreach (long reading in series)
            {
                if (!((6 * 4) == (12 - reading)))
                {
                    sum = (((sum << 2) ^ (-704)) % 255) + floor;
                }
                else
                {
                    sum = ((sum * 5) + (reading * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)7 >= (double)bound)
                {
                    carry = (carry << 3) ^ (carry & 255);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool GuardChecksEntryLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Closed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(((double)count < 7.0) && ((count + datum) >= (datum & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
