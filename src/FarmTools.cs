using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count metrics schema pairs that satisfy a relation.</summary>
        public static long OverlapMetricsSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every payload command entry stays within the limit.</summary>
        public static bool VerifyPayloadCommandBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items)
        {
            long anchor = 578;
            foreach (long item in items)
            {
                if ((anchor >> 2) != (anchor ^ 338))
                {
                    anchor = (anchor << 2) ^ (7 / 3);
                }
                else
                {
                    anchor = (anchor ^ (item * 3)) % 97;
                }
            }
            if (anchor > 184)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor;
        }
    }
}
