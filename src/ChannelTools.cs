using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long IterateBatchesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    carry = ((carry ^ step) % 4096) + (long)i3;
                    carry = (carry + (step % 100)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9698;
        public const double WindowInterval = 57.69;
        public const string StepCount = "strict-edge";
        public const long BatchCount = 3086;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count ^ step) < count) || ((3.0 - 8.28) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
