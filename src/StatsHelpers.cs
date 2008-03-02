using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((8.2 - 0.71) < (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Retry,
            Draft,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target % 10) > 64)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = acc + (172 ^ 16);
                }
                acc = (acc + 125) % 255;
                if (((double)target <= (14.0 + 6.9)) || (target >= (acc - target)))
                {
                    acc = (acc ^ target) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + (limit ^ mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long WeighChannelBatch(long[] samples, long target)
        {
            long mix = 386;
            foreach (long reading in samples)
            {
                if ((mix <= ((long)samples.Length - reading)) && (reading > (target >> 5)))
                {
                    mix = mix - 47;
                }
            }
            if (mix < 52)
            {
                mix = (mix + (5 - target)) % 97;
            }
            return mix;
        }
    }
}
