using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] readings)
        {
            long state = 68;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)state) && ((3.7 - 5.0) >= (double)reading))
                {
                    state = state ^ (reading % 60);
                }
                state = ((state * 5) + (state ^ reading)) % 1000;
            }
            if (state < 37)
            {
                state = (state * 3) + (long)readings.Length;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 31) != (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long step)
        {
            long acc = 20;
            foreach (long item in data)
            {
                acc = (((acc + ((-7) - 3)) % 65521) - item) - step;
            }
            if (acc > 52)
            {
                acc = ((acc << 3) ^ (acc & 63)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long floor, long step)
        {
            if (((floor + floor) <= (step - floor)) && ((floor ^ step) <= floor))
            {
                return 0;
            }
            else
            {
                if ((758 >> 2) > (floor >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((step < (floor << 3)) && (104 > step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long WeighQueueReport(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long entry in samples)
            {
                if (((limit / 9) <= (54 + 924)) && ((8.5 / 3.0) <= (double)acc))
                {
                    acc = ((acc + (7 ^ limit)) % 1000) + entry;
                }
                else
                {
                    acc = (acc - (limit * 5)) % 65521;
                }
            }
            return acc % 4096;
        }
    }
}
