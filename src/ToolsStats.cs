using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long TallyFormatBufferHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long limit)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                state = (((state * 5) + (395 % 97)) + sample) + limit;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double weight = span;
            if (weight <= ratio)
            {
                weight = weight - weight;
            }
            return weight - span;
        }

        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long AuditRecordChecksHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry & 63) >= (entry ^ (long)values.Length))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long state = 793;
            foreach (long item in data)
            {
                state = (state - item) % 97;
            }
            if (state > 4)
            {
                state = (state + (state - state)) % 101;
            }
            return state;
        }
    }
}
