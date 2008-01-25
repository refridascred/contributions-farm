using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long WeighFormatRecord(long[] readings, long bound)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = (acc ^ (bound + 126)) - item;
            }
            if (acc > 5)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if ((state > (state << 1)) || ((2.0 + 6.0) < (double)reading))
                {
                    state = state + state;
                }
            }
            if (state < 4)
            {
                state = ((state * 4) + (1 - state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (9 > (cell << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit + limit) < 41)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up window context samples.</summary>
        public static long OverlapWindowContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
