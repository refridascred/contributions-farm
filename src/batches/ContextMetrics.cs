using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((0.4 + 6.6) >= (double)tally))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Validate command report readings against a bound.</summary>
        public static bool GuardCommandReportRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix ^ (mix / 4);
                mix = (mix + (seed ^ seed)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long origin)
        {
            long result = 58;
            foreach (long datum in readings)
            {
                if ((datum * 5) > (result & 3))
                {
                    result = (result << 2) ^ (origin / 8);
                }
            }
            if (result > 7)
            {
                result = (result + origin) % 101;
            }
            return result;
        }
    }
}
