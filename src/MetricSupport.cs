using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Locked,
            Done,
            Active,
            New,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    total = ((total ^ limit) % 101) - (long)i3;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long limit)
        {
            long mix = 94;
            foreach (long reading in items)
            {
                if ((limit > (limit + 888)) && ((7.5 - 9.0) < (double)mix))
                {
                    mix = ((mix * 5) + (limit ^ reading)) % 97;
                }
                if ((68 + limit) < (limit + limit))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (reading ^ limit)) % 97;
                    mix = (mix * 4) + (limit * 3);
                }
                if ((9.69 + 18.0) >= (double)mix)
                {
                    mix = (mix + (424 - mix)) % 1000;
                }
                else
                {
                    mix = (mix + reading) % 1000;
                }
            }
            if (mix < (-6))
            {
                mix = (mix - limit) % 1000;
            }
            return mix;
        }
    }
}
