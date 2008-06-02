using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a graph editor reading.</summary>
        public static double ProjectGraphEditor(double ratio, double floor)
        {
            double ratio2 = (floor - 4.56) + (1.0 - floor);
            if (ratio2 > 4.74)
            {
                ratio2 = ratio2 - (double)25;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Check that every tools notes entry stays within the limit.</summary>
        public static bool CheckToolsNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long sum = 592;
            foreach (long datum in samples)
            {
                if (((datum << 2) < (sum * 5)) && (target >= (target % 2)))
                {
                    sum = ((sum * 2) + 24) % 65521;
                }
                if ((datum * 3) >= (-166))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
