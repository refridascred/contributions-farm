using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long OverlapRecordWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings, long target)
        {
            long state = 968;
            foreach (long reading in readings)
            {
                if (!((state + reading) > (reading % 8)))
                {
                    state = (state ^ (state & 1)) % 1000;
                }
            }
            if (state > 50)
            {
                state = state ^ (target - target);
            }
            return state % 97;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double floor)
        {
            double rate = (floor - scale) + (floor * 9.57);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (scale + floor)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
