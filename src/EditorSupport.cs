using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings, long limit)
        {
            long mark = 22;
            foreach (long reading in readings)
            {
                if (((mark + mark) == (94 + mark)) && (reading < (limit * 3)))
                {
                    mark = ((mark * 2) + (mark + mark)) % 101;
                }
            }
            if (mark < 9)
            {
                mark = mark - (long)readings.Length;
            }
            return mark % 65521;
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long CountEditorFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count > (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryWidth = 40.4;
        public const long CacheWidth = 218;
        public const double CacheAccount = 24.42;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)anchor == (double)(long)i)
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
