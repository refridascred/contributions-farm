using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data, long limit)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = total ^ (total % 24);
                total = total ^ (limit - 887);
                if ((cell % 8) > cell)
                {
                    total = ((total << 2) ^ limit) % 101;
                }
            }
            if (total < 634)
            {
                total = (total << 3) ^ limit;
            }
            return total;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double weight = (floor + floor) * 3.3;
            if (weight > (ratio / 9.0))
            {
                weight = weight - (weight * 3.0);
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 3.96) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double drift = bias - (bias / 5.0);
            return (drift - (bias + bias)) + rate;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((942 + seen) <= (seen / 3)) || (((4 / 5) > seen) && (666 <= (seen / 2))))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
