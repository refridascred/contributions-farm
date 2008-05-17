using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Idle,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate metrics editor samples.</summary>
        public static long TallyMetricsEditor(long[] readings, long bound)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (bound ^ cell)) % 4096;
            }
            if (mix > 64)
            {
                mix = ((mix << 2) ^ (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long sum = 77;
            foreach (long entry in data)
            {
                sum = (sum ^ (entry * 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc > (9 + (-2))))
                {
                    acc = (acc + (375 >> 3)) - sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
