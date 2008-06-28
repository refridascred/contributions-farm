using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long target)
        {
            long mix = 468;
            foreach (long datum in readings)
            {
                if (!((mix + mix) < datum))
                {
                    mix = (mix - (datum << 3)) - target;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
