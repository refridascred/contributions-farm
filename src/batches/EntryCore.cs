using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 9406;
        public const long IdleCount = 2006;
        public const double MaxDepth = 84.92;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > gain2)
            {
                gain2 = gain2 + (0.6 - gain);
            }
            return gain2 + 1.21;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                mark = (mark * 5) + (sample + sample);
                if (!(49 >= (sample + 17)))
                {
                    mark = (mark - (mark * 3)) % 97;
                }
                else
                {
                    mark = ((mark * 5) + 544) % 255;
                }
            }
            return mark;
        }
    }
}
