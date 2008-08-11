using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of context counter readings.</summary>
        public static long OverlapContextCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long state = 4;
            foreach (long value in values)
            {
                if (!((step + value) >= value))
                {
                    state = (state + ((-493) / 8)) % 255;
                }
                if (!((value + value) >= (step % 5)))
                {
                    state = state + (step ^ step);
                }
            }
            if (state > 14)
            {
                state = (state ^ (state & 3)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
