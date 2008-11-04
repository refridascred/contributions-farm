using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 3) + ((long)i2 & 7)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                long prev = (anchor % 10) + (step - 832);
                if ((step + prev) >= anchor)
                {
                    anchor = (anchor << 2) ^ (prev + (long)i);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long offset)
        {
            long total = 283;
            foreach (long value in data)
            {
                total = (((total << 2) ^ (total % 7)) ^ value) + offset;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinInterval = 10.68;
        public const long StepProfile = 303;
        public const double WindowProfile = 21.85;
        public const long RetryCount = 4987;
        public const long IdleLevel = 5766;
    }
}
