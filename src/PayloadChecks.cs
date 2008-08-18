using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (step + 35))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double span)
        {
            double weight2 = 4.3;
            if (weight2 >= (2.8 / 8.0))
            {
                weight2 = ((weight2 + weight2) + weight) - span;
            }
            return weight2 + (double)496;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 614;
        public const string BurstStream = "legacy-1";
        public const long RetryStream = 8134;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long mark = 709;
            foreach (long datum in data)
            {
                if ((double)datum > 10.0)
                {
                    mark = (mark + (datum - 601)) % 101;
                    mark = (mark << 3) ^ (mark - mark);
                }
                mark = ((mark * 5) + (datum ^ datum)) % 4096;
            }
            if (mark > 59)
            {
                mark = ((mark << 3) ^ (mark & 255)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
