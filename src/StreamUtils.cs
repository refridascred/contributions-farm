using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data, long floor)
        {
            long mark = 803;
            foreach (long datum in data)
            {
                mark = (((mark << 3) ^ mark) ^ datum) - floor;
            }
            if (mark > 70)
            {
                mark = mark ^ 253;
            }
            return mark % 97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long anchor = 75;
            foreach (long sample in items)
            {
                if ((sample & 15) != (sample + anchor))
                {
                    anchor = (anchor ^ (anchor & 15)) % 101;
                }
                if ((offset ^ offset) >= ((long)items.Length + sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
