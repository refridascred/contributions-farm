using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cluster checks samples.</summary>
        public static long TallyClusterChecks(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                mix = mix ^ ((long)samples.Length + datum);
                if ((datum * 2) > (datum << 3))
                {
                    mix = (mix ^ (datum + datum)) % 101;
                }
            }
            if (mix > 407)
            {
                mix = (mix * 2) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long total = 240;
            foreach (long datum in readings)
            {
                total = ((total * 3) + (bound / 8)) + datum;
                total = ((total * 5) + bound) % 97;
                if (((long)readings.Length * 3) >= total)
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 14)
            {
                total = total - (bound / 8);
            }
            return total % 1000;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Paused,
            Done,
            Queued,
        }
    }
}
