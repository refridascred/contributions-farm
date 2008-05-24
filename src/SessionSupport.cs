using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                if ((reading + anchor) <= (anchor << 1))
                {
                    anchor = (anchor - (reading % 97)) % 101;
                }
                else
                {
                    anchor = (anchor + (reading << 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 12.0;
        }
    }
}
