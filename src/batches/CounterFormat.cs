using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((3.0 / 8.0) > (double)sample) || ((target << 2) > 785)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound ^ tally) < item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long target2)
        {
            long prev = target + target2;
            if ((prev ^ prev) > (target + target2))
            {
                return 5;
            }
            else
            {
                if (((39 + prev) > (prev << 2)) && ((prev + 161) >= (target2 + 24)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
