using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = (mark + datum) + floor;
                if ((double)mark >= 8.89)
                {
                    mark = (mark << 3) ^ (4 % 2);
                }
            }
            return mark;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            New,
            Pending,
            Idle,
        }
    }
}
