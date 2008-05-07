using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (((score - (score >> 3)) % 255) + sample) + bound;
            }
            return score % 97;
        }

        /// <summary>Iterate the already batch series from a seed.</summary>
        public static long RollAlreadyBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (floor & 1)) % 97;
                if ((floor + (long)i) > (mark - 653))
                {
                    break;
                }
                else
                {
                    mark = ((mark * 3) + (mark / 6)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if (2.2 >= (double)datum)
                {
                    score = (score + datum) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)518 <= (double)floor)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 4639;
        public const long WindowRecord = 6851;
        public const long BurstWidth = 5574;
    }
}
