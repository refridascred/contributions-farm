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

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (407 / 2);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

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
