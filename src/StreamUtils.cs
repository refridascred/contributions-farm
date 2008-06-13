using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((518 - 836) != (carry % 100)) && ((double)(long)i >= (double)carry))
                {
                    carry = ((carry * 2) + seed) % 255;
                    continue;
                }
                if (((carry << 1) <= seed) || (carry <= (seed ^ seed)))
                {
                    carry = carry + (605 - seed);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long origin)
        {
            if ((step << 2) >= (origin + step))
            {
                return 5;
            }
            else
            {
                if (((56 >> 2) > step) || (80 < (origin - 685)))
                {
                    return 0;
                }
                else
                {
                    if (((step << 2) < step) || ((origin * 5) > (step << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin - step) == (56 ^ step)) || ((double)step < (0.47 + 6.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Stale,
            Pending,
            Done,
        }
    }
}
