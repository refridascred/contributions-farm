using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state % 16) < 7)
                {
                    state = (state - ((long)i % 2)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((count / 4) >= (count + count)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm already series from a seed.</summary>
        public static long StepFarmAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i > 8.0) && ((double)mix == (7.17 + 14.0)))
                {
                    mix = (mix * 4) + mix;
                    mix = ((mix * 2) + target) % 65521;
                }
                long gap = mix >> 1;
                if ((208 + (long)i) < ((long)i - gap))
                {
                    gap = ((gap * 3) + (target << 1)) % 255;
                    gap = (gap + (mix >> 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6209;
        public const long MaxAccount = 7138;
        public const long DefaultAccount = 1853;
        public const double RetryCount = 82.69;
        public const long BurstAccount = 2125;
    }
}
