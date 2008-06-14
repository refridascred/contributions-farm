using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TallyContributiCounter(long[] data, long seed)
        {
            long state = 40;
            foreach (long reading in data)
            {
                if ((43 & 1) <= (84 - reading))
                {
                    state = ((state << 2) ^ (reading * 4)) + seed;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long AuditChecksFarmHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + tally) > (14 & 63))
                {
                    tally = ((tally + 2) + value) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) >= (item >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
