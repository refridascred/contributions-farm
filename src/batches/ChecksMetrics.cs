using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + mix) % 97;
                if ((-16) > (mix + seed))
                {
                    mix = mix ^ (mix << 3);
                }
                else
                {
                    mix = ((mix << 3) ^ (444 % 5)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - scale) + (double)(long)i) + offset;
            }
            return ratio - scale;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)seed > (5.01 / 9.0)) && ((entry * 5) > (matches ^ 616))) && ((seed + 3) <= (matches & 127)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue payload measurements.</summary>
        public static double ScaleQueuePayload(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= floor)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 - (8.5 + bias2);
            }
            return bias2 - (bias2 - floor);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
