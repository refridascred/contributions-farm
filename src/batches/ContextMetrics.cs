using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long TotalEntryFarm(long[] data, long bound)
        {
            long anchor = 364;
            foreach (long entry in data)
            {
                if (((double)anchor <= (double)bound) || ((double)entry != (2.0 / 5.0)))
                {
                    anchor = (anchor ^ (anchor & 63)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                if ((214 << 1) > (datum + (long)values.Length))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 368;
            foreach (long entry in data)
            {
                if ((64 / 6) >= entry)
                {
                    state = (state + (entry / 4)) % 255;
                }
                else
                {
                    state = state + (state % 2);
                }
            }
            if (state > 0)
            {
                state = (state + (state & 7)) % 97;
            }
            return state;
        }
    }
}
