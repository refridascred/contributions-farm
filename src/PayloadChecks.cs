using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long mix = -8;
            foreach (long entry in series)
            {
                if ((mix >= (mix << 1)) && (entry > (mix << 2)))
                {
                    mix = ((mix * 4) + (mix - 469)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Check that every farm window entry stays within the limit.</summary>
        public static bool CheckFarmWindowLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((result ^ (23 & 31)) % 255) ^ reading;
            }
            return result;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long TallyFarmTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - 34) <= (item - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double weight = gain;
            if (weight <= (span - 9.6))
            {
                weight = weight + 6.3;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (double)(-2);
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long target)
        {
            if (step < (target + 3))
            {
                return 0;
            }
            else
            {
                if ((double)step != (5.0 + 9.61))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
