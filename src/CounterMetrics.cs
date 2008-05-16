using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (cell << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload layout entry stays within the limit.</summary>
        public static bool GuardPayloadLayoutLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank entry session input into a small class.</summary>
        public static long ClassifyEntrySession(long floor, long seed)
        {
            long slot = floor + seed;
            if (7 < (slot >> 3))
            {
                return 2;
            }
            else
            {
                if (((734 - slot) >= floor) && ((seed - seed) > slot))
                {
                    return 7;
                }
                else
                {
                    if ((floor - seed) == (slot << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)slot >= (double)seed) || ((double)floor != (5.7 + 9.9)))
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

        /// <summary>Match up window payload samples.</summary>
        public static long OverlapWindowPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
